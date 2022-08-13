using System.ComponentModel.DataAnnotations;

namespace Desafio_digital_mark.Application.ViewModel;

public class ProjetoViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [MinLength(1)]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A tecnologia é obrigatória")]
    [MinLength(1)]
    [MaxLength(200)]
    public string Tecnologia { get; set; }
    public int ClienteId { get; set; }   
    public ClienteViewModel Cliente { get; set; }
}
