using System.ComponentModel.DataAnnotations;

namespace F1API.Models;
public class Driver
{
    [Key]
    [Required]
    public int Id { get; set; } // Assuming you have an ID for each driver, even if not used in the example
    [Required(ErrorMessage="O nome do piloto é obrigatorio")]
    [StringLength(100, ErrorMessage = "O nome do piloto deve ter no máximo 100 caracteres")]
    public string name { get; set; }
    [Required(ErrorMessage = "O nome da equipe é obrigatorio")]
    [StringLength(100, ErrorMessage = "O nome da equipe deve ter no máximo 100 caracteres")]
    public string team { get; set; }
    [Required(ErrorMessage = "A quantidade de vitórias é obrigatoria")]
    [Range(0, int.MaxValue, ErrorMessage = "A quantidade de vitórias deve ser um número positivo")]
    public int wins { get; set; }
    [Required(ErrorMessage = "A quantidade de podius é obrigatoria")]
    [Range(0, int.MaxValue, ErrorMessage = "A quantidade de podius deve ser um número positivo")]
    public int podiums { get; set; }
}
