using System.ComponentModel.DataAnnotations;
public class log
{   [Required(ErrorMessage ="informe um email")]
    public string email{ get; set; }
    [Required(ErrorMessage ="informe uma senha")]
    public string senha{get; set;}
}