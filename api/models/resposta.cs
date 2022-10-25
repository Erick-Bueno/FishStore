public class Resposta
{
    public Resposta(int codigo, string mensagem, object dados, string link, string tipo)
    {
        Codigo = codigo;
        this.mensagem = mensagem;
        this.dados = dados;
        this.link = link;
        this.tipo = tipo;
    }

    public int Codigo { get; set; }
    public string mensagem {get; set;}
    public object dados{get; set;}
    public string tipo {get; set;}
    public string link {get; set;}
}