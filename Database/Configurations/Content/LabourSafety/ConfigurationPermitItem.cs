using Database.Models.Content.LabourSafety;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.LabourSafety
{
    public class ConfigurationPermitItem : IEntityTypeConfiguration<PermitItem>
    {
        public void Configure(EntityTypeBuilder<PermitItem> builder)
        {
            builder.ToTable("PermitItems", "dbo.Content.LabourSafety");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}