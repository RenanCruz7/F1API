using System.ComponentModel.DataAnnotations;

namespace F1API.Data.Dtos;
public class CreateDriverDto
{
    [Required(ErrorMessage = "O nome do piloto é obrigatorio")]
    public string name { get; set; }
    [Required(ErrorMessage = "O nome da equipe é obrigatorio")]
    public string team { get; set; }
    [Required(ErrorMessage = "A quantidade de vitórias é obrigatoria")]
    [Range(0, int.MaxValue, ErrorMessage = "A quantidade de vitórias deve ser um número positivo")]
    public int wins { get; set; }
    [Required(ErrorMessage = "A quantidade de podius é obrigatoria")]
    [Range(0, int.MaxValue, ErrorMessage = "A quantidade de podius deve ser um número positivo")]
    public int podiums { get; set; }
}
