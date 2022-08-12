using Desafio_digital_mark.Domain.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio_digital_mark.Data.Map;
public class ProjetoMap : IEntityTypeConfiguration<Projeto>
{
    public void Configure(EntityTypeBuilder<Projeto> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder
            .Property(x => x.Nome)
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder
            .Property(x => x.Tecnologia)
            .HasColumnType("VARCHAR(200)")
            .IsRequired();

        builder
            .HasOne(p => p.Cliente)
            .WithOne(c => c.Projeto)
            .HasForeignKey<Projeto>(p => p.ClienteId);

    }
}
