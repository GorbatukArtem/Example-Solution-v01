using Database.Models.Content.OrgProcesses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgProcesses
{
    public class ConfigurationProcessCriticality : IEntityTypeConfiguration<ProcessCriticality>
    {
        public void Configure(EntityTypeBuilder<ProcessCriticality> builder)
        {
            builder.ToTable("ProcessCriticalities", "dbo.Content.OrgProcesses");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}