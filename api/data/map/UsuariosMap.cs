using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

 class UsuariosMap : IEntityTypeConfiguration<Usuarios>
{
    public void Configure(EntityTypeBuilder<Usuarios> builder)
    {
        builder.HasKey(c => c.id);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(600);
        builder.Property(c => c.Senha).IsRequired().HasMaxLength(600);

    }
}