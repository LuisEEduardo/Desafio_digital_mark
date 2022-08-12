using Desafio_digital_mark.Domain.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Desafio_digital_mark.Data.Repositorio;

public class RepositorioBase<T> : IRepositorioBase<T> where T : class
{

    private readonly Contexto _contexto;

    public RepositorioBase(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task Incluir(T entidade)
    {
        _contexto.Set<T>().Add(entidade);
        await _contexto.SaveChangesAsync();
    }

    public async Task Alterar(T entidade)
    {
        _contexto.Set<T>().Update(entidade);
        await _contexto.SaveChangesAsync();
    }

    public async Task<T> Selecionar(Expression<Func<T, bool>> expressao)
        => await _contexto.Set<T>()
                          .SingleOrDefaultAsync(expressao);

    public async Task<IEnumerable<T>> SelecionarTodos()
        => await _contexto.Set<T>()
                          .AsNoTracking()
                          .ToArrayAsync();

    public async Task Excluir(Expression<Func<T, bool>> expressao)
    {
        var entidade = await Selecionar(expressao);
        _contexto.Set<T>().Remove(entidade);
        await _contexto.SaveChangesAsync();
    }

    public void Dispose()
    {
        _contexto.Dispose();
    }
}
