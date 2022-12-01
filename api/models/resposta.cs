public class Resposta
{
    public Resposta(int status, string mensagem, object dados, string link, string tipo, string urlimg)
    {
        Status = status;
        this.mensagem = mensagem;
        this.dados = dados;
        this.link = link;
        this.tipo = tipo;
        this.urlimg = urlimg;
    }

    public int Status { get; set; }
    public string mensagem {get; set;}
    public object dados{get; set;}
    public string tipo {get; set;}
    public string link {get; set;}
    public string urlimg {get; set;}
}