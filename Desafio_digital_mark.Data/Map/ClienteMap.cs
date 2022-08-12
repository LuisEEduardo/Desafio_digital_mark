using Desafio_digital_mark.Domain.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio_digital_mark.Data.Map;

public class ClienteMap : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
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
    }
}
