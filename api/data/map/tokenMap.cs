using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class tokenMap : IEntityTypeConfiguration<Token>
{
    public void Configure(EntityTypeBuilder<Token> builder)
    {
        builder.HasKey(d => d.id);
        builder.Property(d => d.Email).IsRequired().HasMaxLength(600);
        builder.Property(d => d.Jwt).IsRequired().HasMaxLength(600);
    }
}