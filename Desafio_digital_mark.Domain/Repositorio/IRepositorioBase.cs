using System.Linq.Expressions;

namespace Desafio_digital_mark.Domain.Repositorio;

public interface IRepositorioBase<T>
{
    void Incluir(T entidade);
    void Alterar(T entidade);
    Task<T> SelecionarPorId(Expression<Func<T, bool>> expressao);
    Task ExcluirPorId(Expression<Func<T, bool>> expressao);
    Task<IEnumerable<T>> SelecionarTodos();
}
