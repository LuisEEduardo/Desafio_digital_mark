namespace Desafio_digital_mark.Application.ViewModel;

public class ProjetoViewModel
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Tecnologia { get; private set; }
    public ClienteViewModel Cliente { get; private set; }
}
