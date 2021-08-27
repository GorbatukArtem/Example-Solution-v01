using Database.Models.Content.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.Services
{
    public class ConfigurationStockProposal : IEntityTypeConfiguration<StockProposal>
    {
        public void Configure(EntityTypeBuilder<StockProposal> builder)
        {
            builder.ToTable("StockProposals", "dbo.Content.Services");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}