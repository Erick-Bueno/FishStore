public class erros{
    public string msg { get; set; }
    public int status {get; set;}

    public erros(string msg, int status)
    {
        this.msg = msg;
        this.status = status;
    }
}