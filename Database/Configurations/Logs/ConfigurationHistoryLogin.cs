using Database.Models.Logs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Logs
{
    public class ConfigurationHistoryLogin : IEntityTypeConfiguration<HistoryLogin>
    {
        public void Configure(EntityTypeBuilder<HistoryLogin> builder)
        {
            builder.ToTable("HistoryLogins", "dbo.Logs");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}