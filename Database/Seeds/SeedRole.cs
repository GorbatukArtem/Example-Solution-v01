using Database.Models.Security.Authorization;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Database.Seeds
{
    public class SeedRole : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role { Id = 1, Name = "Visitor" });
            builder.HasData(new Role { Id = 2, Name = "Administrator" });
        }
    }
}