using Database.Models.Security.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Security.Access
{
    public class ConfigurationRequestedRole : IEntityTypeConfiguration<RequestedRole>
    {
        public void Configure(EntityTypeBuilder<RequestedRole> builder)
        {
            builder.ToTable("RequestedRoles", "dbo.Security.Access");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}