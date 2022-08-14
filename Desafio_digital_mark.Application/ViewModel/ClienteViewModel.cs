using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_digital_mark.Application.ViewModel;

public class ClienteViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [MinLength(3, ErrorMessage = "O nome deve ter mais de 3 caracteres")]
    [MaxLength(100, ErrorMessage = "O nome deve ter até 100 caracteres")]
    public string Nome { get; set; }
}
