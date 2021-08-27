using Database.Models.Logs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Logs
{
    public class ConfigurationHistoryError : IEntityTypeConfiguration<HistoryError>
    {
        public void Configure(EntityTypeBuilder<HistoryError> builder)
        {
            builder.ToTable("HistoryErrors", "dbo.Logs");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}