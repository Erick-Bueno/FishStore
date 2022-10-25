using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

class PeixesMap : IEntityTypeConfiguration<Peixes>
{
    public void Configure(EntityTypeBuilder<Peixes> builder)
    {
        builder.HasKey(x => x.id);
        builder.Property(x => x.NomePeixe).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Descricao).IsRequired().HasMaxLength(600);
        builder.Property(x => x.imagem).HasMaxLength(100);
    }
}