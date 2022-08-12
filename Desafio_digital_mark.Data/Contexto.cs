using Desafio_digital_mark.Domain.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Desafio_digital_mark.Data;

public class Contexto : DbContext
{   
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Projeto> Projeto { get; set; }

    public Contexto(DbContextOptions<Contexto> options)
       : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        base.OnModelCreating(modelBuilder);
    }
}
