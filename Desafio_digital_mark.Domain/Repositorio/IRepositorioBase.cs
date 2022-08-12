using System.Linq.Expressions;

namespace Desafio_digital_mark.Domain.Repositorio;

public interface IRepositorioBase<T> : IDisposable where T : class
{
    Task Incluir(T entidade);
    Task Alterar(T entidade);
    Task<T> Selecionar(Expression<Func<T, bool>> expressao);
    Task Excluir(Expression<Func<T, bool>> expressao);
    Task<IEnumerable<T>> SelecionarTodos();
}
