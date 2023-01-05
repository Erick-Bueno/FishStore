 using System.ComponentModel.DataAnnotations;
 public class Usuarios
{
    public int id { get; set; }
    [Required (ErrorMessage = "informe um nome")]
    public string Nome { get; set; }
    [Required(ErrorMessage ="informe um email")]
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="informe um email valido")]
    public string Email { get; set; }
    [Required(ErrorMessage ="informe uma senha")]
    [RegularExpression("^(?=.*[A-Z])(?=.*[!#@$%&])(?=.*[0-9])(?=.*[a-z]).{6,15}$", ErrorMessage ="A senha deve conter 6 digitos, letra maiuscula e caracter especial")]
    public string Senha { get; set; }
}