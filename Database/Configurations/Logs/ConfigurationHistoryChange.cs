using Database.Models.Logs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Logs
{
    public class ConfigurationHistoryChange : IEntityTypeConfiguration<HistoryChange>
    {
        public void Configure(EntityTypeBuilder<HistoryChange> builder)
        {
            builder.ToTable("HistoryChanges", "dbo.Logs");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}