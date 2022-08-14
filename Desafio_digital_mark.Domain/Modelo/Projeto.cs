using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_digital_mark.Domain.Modelo;

public class Projeto
{
    public static Projeto CriarProjeto(string nome, string tecnologia, int clienteId)
    {
        Projeto projeto = new()
        {
            Nome = nome,
            Tecnologia = tecnologia,
            ClienteId = clienteId
        };

        return projeto;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Tecnologia { get; private set; }
    public Cliente Cliente { get; private set; }
    public int ClienteId { get; private set; }

    public void AlterarNome(string nome)
    {
        Nome = nome;
    }

    public void AlterarTecnologia(string tecnologia)
    {
        Tecnologia = tecnologia;
    }

    public void AlterarCliente(int clienteId)
    {
        ClienteId = clienteId;
    }

}
