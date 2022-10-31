public class Resposta
{
    public Resposta(int codigo, string mensagem, object dados, string link, string tipo, string urlimg)
    {
        Codigo = codigo;
        this.mensagem = mensagem;
        this.dados = dados;
        this.link = link;
        this.tipo = tipo;
        this.urlimg = urlimg;
    }

    public int Codigo { get; set; }
    public string mensagem {get; set;}
    public object dados{get; set;}
    public string tipo {get; set;}
    public string link {get; set;}
    public string urlimg {get; set;}
}