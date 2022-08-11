namespace Desafio_digital_mark.Domain.Modelo;

public class Cliente
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }

    public void AlterarNome(string nome)
    {
        Nome = nome;
    }

}
