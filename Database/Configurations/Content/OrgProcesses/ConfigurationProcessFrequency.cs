using Database.Models.Content.OrgProcesses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgProcesses
{
    public class ConfigurationProcessFrequency : IEntityTypeConfiguration<ProcessFrequency>
    {
        public void Configure(EntityTypeBuilder<ProcessFrequency> builder)
        {
            builder.ToTable("ProcessFrequencies", "dbo.Content.OrgProcesses");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}