using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.AppCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.Property(p => p.Nome)
               .HasColumnType("varchar(400)")
               .IsRequired();

            builder.Property(p => p.CBO)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.Property(p => p.Descricao)
               .HasColumnType("varchar(1000)")
               .IsRequired();
        }
    }
}