using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infra.Mapping
{
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
