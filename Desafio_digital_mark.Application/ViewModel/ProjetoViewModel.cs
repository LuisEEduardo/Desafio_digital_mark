using System.Text.Json.Serialization;

namespace Desafio_digital_mark.Application.ViewModel;

public class ProjetoViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Tecnologia { get; set; }
    public int ClienteId { get; set; }   
    public ClienteViewModel Cliente { get; set; }
}
