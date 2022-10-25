using System.ComponentModel.DataAnnotations;
public class Peixes
{
    
    public int id { get; set; }
    [Required(ErrorMessage ="o nome do peixe é obrigatorio")]
    [RegularExpression(@"^[A-Za-z]{1,}$", ErrorMessage ="informe um nome valido para o campo NomePeixe")]
    public string NomePeixe { get; set; }
    public string Descricao { get; set; }
    public string imagem { get; set; }
}