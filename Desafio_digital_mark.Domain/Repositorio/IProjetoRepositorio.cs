using Desafio_digital_mark.Domain.Modelo;
using System.Linq.Expressions;

namespace Desafio_digital_mark.Domain.Repositorio;

public interface IProjetoRepositorio : IRepositorioBase<Projeto>
{
    Task<IEnumerable<Projeto>> SelecionarProjetosComClientesAsync();
    Task<Projeto> SelecionarProjetoComCliente(Expression<Func<Projeto, bool>> expressao);
}
