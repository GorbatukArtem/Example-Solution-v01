using Database.Models.Content.OrgPositions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgPositions
{
    public class ConfigurationBackup : IEntityTypeConfiguration<Backup>
    {
        public void Configure(EntityTypeBuilder<Backup> builder)
        {
            builder.ToTable("Backups", "dbo.Content.OrgPositions");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}