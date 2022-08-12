namespace Desafio_digital_mark.Domain.Modelo;

public class Cliente
{
    public static Cliente CriarCliente(string nome)
    {
        Cliente cliente = new()
        {
            Nome = nome
        };

        return cliente;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    
    public Projeto Projeto { get; private set; }

    public void AlterarNome(string nome)
    {
        Nome = nome;
    }

}
