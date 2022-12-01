using System.ComponentModel.DataAnnotations;
public class Peixes
{
    
    public int id { get; set; }
    [Required(ErrorMessage ="O nome do peixe é obrigatorio")]
    [RegularExpression(@"^[A-Za-z]{1,}$", ErrorMessage ="Informe um nome valido para o nome do peixe")]
    public string NomePeixe { get; set; }
    [Required(ErrorMessage ="Informe uma descrição para o peixe")]
    public string Descricao { get; set; }

    public string imagem { get; set; }
}