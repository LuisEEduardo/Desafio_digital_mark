using Desafio_digital_mark.Domain.Modelo;
using Desafio_digital_mark.Domain.Repositorio;

namespace Desafio_digital_mark.Data.Repositorio;

public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
{
    public ClienteRepositorio(Contexto contexto)
        : base(contexto)
    {
    }
}
