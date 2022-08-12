using Desafio_digital_mark.Application.ViewModel;

namespace Desafio_digital_mark.Application.Interface;

public interface IClienteAplicacao
{
    Task Incluir(ClienteViewModel cliente);
    Task Alterar(ClienteViewModel cliente);
    Task<ClienteViewModel> SelecionarPorId(int id);
    Task Excluir(int id);
    Task<IEnumerable<ClienteViewModel>> SelecionarTodos();
}
