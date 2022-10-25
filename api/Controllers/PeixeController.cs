namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class PeixeController : ControllerBase
    {
        public IPeixesService peixesService;

        public PeixeController(IPeixesService peixesService)
        {
            this.peixesService = peixesService;
        }

        [HttpPost]
        public async Task<ActionResult<Peixes>> Adicionar_peixe([FromForm] IFormFile imagem, [FromForm] Peixes peixe)
        {
            
               string nome_img =Guid.NewGuid() +"_"+ imagem.FileName;
               peixe.imagem = nome_img;
               string url = @"C:\Users\erick\Documents\Linguas-20220714T235342Z-001\Linguas\html-css\projetos\Ecommercepeixes4.0\api\imagens\";
               if(!Directory.Exists(url)){
                Directory.CreateDirectory(url);
               }
               using(var stream=System.IO.File.Create(url + nome_img)){
                await imagem.CopyToAsync(stream);
               }
                await peixesService.AdicionarPeixe(peixe);
                Resposta res = new Resposta(202,"peixe adicionado com sucesso", peixe, "http://localhost:7179/api/Peixe","GET");
                
                return Ok(res);
               
            
            
            
            
        }
    }
}