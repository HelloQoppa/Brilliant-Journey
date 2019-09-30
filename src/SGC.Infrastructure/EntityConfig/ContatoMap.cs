using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.AppCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        { 

            builder.Property(e => e.Nome)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(e => e.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(e => e.Telefone)
               .HasColumnType("varchar(15)");
        }
    }
}