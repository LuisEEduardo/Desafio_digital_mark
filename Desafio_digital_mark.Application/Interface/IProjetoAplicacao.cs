using Desafio_digital_mark.Application.ViewModel;

namespace Desafio_digital_mark.Application.Interface;

public interface IProjetoAplicacao
{
    Task Incluir(ProjetoViewModel projeto);
    Task Alterar(ProjetoViewModel projeto);
    Task<ProjetoViewModel> SelecionarPorId(int id);
    Task Excluir(int id);
    Task<IEnumerable<ProjetoViewModel>> SelecionarTodos();
}
