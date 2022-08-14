using Desafio_digital_mark.Domain.Modelo;
using Desafio_digital_mark.Domain.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Desafio_digital_mark.Data.Repositorio;

public class ProjetoRepositorio : RepositorioBase<Projeto>, IProjetoRepositorio
{
    public ProjetoRepositorio(Contexto contexto)
        : base(contexto)
    {
    }

    public async Task<Projeto> SelecionarProjetoComCliente(Expression<Func<Projeto, bool>> expressao)
        => await _contexto
                    .Projeto
                    .AsNoTracking()
                    .Include(p => p.Cliente)
                    .SingleOrDefaultAsync(expressao);

    public async Task<IEnumerable<Projeto>> SelecionarProjetosComClientesAsync()
        => await _contexto
                    .Projeto
                    .Include(p => p.Cliente)
                    .AsNoTracking()
                    .ToArrayAsync();
                            


}
