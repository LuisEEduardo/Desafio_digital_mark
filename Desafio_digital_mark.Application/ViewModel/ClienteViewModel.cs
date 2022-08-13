using System.ComponentModel.DataAnnotations;

namespace Desafio_digital_mark.Application.ViewModel;

public class ClienteViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [MinLength(1)]
    [MaxLength(100)]
    public string Nome { get; set; }
}
