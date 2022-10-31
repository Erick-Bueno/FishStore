namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class PeixeController : ControllerBase
    {
        public IPeixesService peixesService;
        public static IWebHostEnvironment _enviroment;

        public PeixeController(IPeixesService peixesService, IWebHostEnvironment environment)
        {   
            _enviroment = environment;
            this.peixesService = peixesService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Adicionar_peixe([FromForm] IFormFile imagem, [FromForm] Peixes peixe)
        {
               
               string nome_img =Guid.NewGuid() +"_"+ imagem.FileName;
               string urlimgg = $"https://localhost:7179/imagens/{nome_img}";
               peixe.imagem = urlimgg;
               //tring url = @"C:\Users\erick\Documents\Linguas-20220714T235342Z-001\Linguas\html-css\projetos\Ecommercepeixes4.0\app\imagens";
               if(!Directory.Exists(_enviroment.WebRootPath + "\\imagens\\"))
               {
                Directory.CreateDirectory(_enviroment.WebRootPath + "\\imagens\\");
               }
               using(var stream=System.IO.File.Create(_enviroment.WebRootPath + "\\imagens\\" + nome_img)){
                await imagem.CopyToAsync(stream);
               }
                await peixesService.AdicionarPeixe(peixe);
                Resposta res = new Resposta(202,"peixe adicionado com sucesso", peixe, "http://localhost:7179/api/Peixe","GET", urlimgg);
                return Ok(res);
                
               
            
            
            
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Peixes>>> listar_Peixes(){
            List<Peixes> peixada = await peixesService.ListarPeixes();
            return Ok(peixada);
            
            
        }
    }
}