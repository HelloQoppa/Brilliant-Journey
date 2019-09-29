using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.AppCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(end => end.Bairro)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(end => end.CEP)
               .HasColumnType("varchar(15)")
               .IsRequired();

            builder.Property(end => end.Logradouro)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(end => end.Referencia)
               .HasColumnType("varchar(400)");
        }

    }
    }