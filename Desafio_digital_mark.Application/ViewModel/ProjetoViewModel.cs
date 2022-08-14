using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_digital_mark.Application.ViewModel;

public class ProjetoViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [MinLength(3, ErrorMessage = "O nome deve ter mais de 3 caracteres")]
    [MaxLength(100, ErrorMessage = "O nome deve ter até 100 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A tecnologia é obrigatória")]
    [MinLength(1, ErrorMessage = "A tecnologia de ter mais de 1 caracter")]
    [MaxLength(200, ErrorMessage = "A tecnologia de ter até 100 caracteres")]
    public string Tecnologia { get; set; }

    public int ClienteId { get; set; }
    public ClienteViewModel Cliente { get; set; }
}
