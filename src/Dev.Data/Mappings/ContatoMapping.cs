using Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dev.Data.Mappings
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.TelefoneResidencial)
                .IsRequired()
                .HasColumnType("varchar(9)");

            builder.Property(c => c.Celular)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.ToTable("Contatos");

        }
    }
}
