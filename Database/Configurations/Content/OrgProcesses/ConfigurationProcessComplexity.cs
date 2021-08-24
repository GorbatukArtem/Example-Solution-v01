using Database.Models.Content.OrgProcesses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgProcesses
{
    public class ConfigurationProcessComplexity : IEntityTypeConfiguration<ProcessComplexity>
    {
        public void Configure(EntityTypeBuilder<ProcessComplexity> builder)
        {
            builder.ToTable("ProcessComplexities", "dbo.Content.OrgProcesses");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}