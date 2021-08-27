using Database.Models.Content.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.Services
{
    public class ConfigurationStockRequest : IEntityTypeConfiguration<StockRequest>
    {
        public void Configure(EntityTypeBuilder<StockRequest> builder)
        {
            builder.ToTable("StockRequests", "dbo.Content.Services");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}