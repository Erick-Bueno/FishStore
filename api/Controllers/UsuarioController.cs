namespace Name.Controllers
{
    using System.Text.Json;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class Usuario : ControllerBase
    {
        private readonly IUsuariosService usuarios;
        private readonly ITokenService tokent;
        private readonly AppDbContext context;

        public Usuario (IUsuariosService usuarios,ITokenService tokent,AppDbContext context)
        {
            this.usuarios = usuarios;
            this.tokent = tokent;
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> cadastro([FromBody] Usuarios usuario)
        {
            try
            {
                await usuarios.verificarEmail(usuario);
            }
            catch (System.Exception ex)
            {
                 erros err = new erros("email ja registrado", 403);
                 return Ok(err);
            }
            

            await usuarios.AdicionarUser(usuario);
            var token = TokenJWT.gerarToken(usuario);

            //adicionando dados na tabela token
            Token tk = new Token();
            tk.Email = usuario.Email;
            tk.Jwt = token;
            await tokent.adicionarToken(tk);
            
            
            
            return Ok($"{usuario.id},{token},202");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> Unicouser(int id){
            Usuarios user = await usuarios.listarunicoUser(id);
            return Ok(user);
        }
        [HttpPost]
        [Route("logar")]
        public async Task<ActionResult<Usuarios>> Login([FromBody] log logg){
               var loggg = context.clientes.Where(u => u.Email == logg.email ).FirstOrDefault();
               
                if (loggg == null){
                    erros err = new erros("Email invalido", 403);
                    return BadRequest(err);
                }
                if(loggg.Senha != logg.senha){
                     erros err = new erros("senha invalida", 403);
                    return BadRequest(err);
                }
                var token = TokenJWT.gerarToken(loggg);
            
            var logg2 = context.Tokens.Where(t => t.Email == loggg.Email).FirstOrDefault();
            if(logg2 != null){
                logg2.Jwt = token;
                await context.SaveChangesAsync();
                 
            }
            else{
                Token tokeen = new Token();
                tokeen.Jwt = token;
                tokeen.Email = loggg.Email;
                await tokent.adicionarToken(tokeen);
            }

            return Ok($"{token}, {loggg.id}, 202");
        }
        [HttpPost]
        [Route("refresh")]
        public async Task<ActionResult<Usuarios>> refreshToken([FromBody]oldToken token){
             var verificar = context.Tokens.Where(t => t.Jwt  == token.oldtoken).FirstOrDefault();

             if(verificar != null){
                var user = context.clientes.Where(u => u.Email == verificar.Email).FirstOrDefault();
                var new_token = TokenJWT.gerarToken(user);
                verificar.Jwt = new_token;
                await context.SaveChangesAsync();
                return Ok(new_token);
             }
             return BadRequest("usuario não encontrado");
         
        }
    }
}