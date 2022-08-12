using Desafio_digital_mark.Domain.Modelo;
using Desafio_digital_mark.Domain.Repositorio;

namespace Desafio_digital_mark.Data.Repositorio;

public class ProjetoRepositorio : RepositorioBase<Projeto>, IProjetoRepositorio
{
    public ProjetoRepositorio(Contexto contexto)
        : base(contexto)
    {
    }
}
