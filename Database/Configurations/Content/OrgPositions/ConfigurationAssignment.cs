using Database.Models.Content.OrgPositions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgPositions
{
    public class ConfigurationAssignment : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments", "dbo.Content.OrgPositions");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.FullTimeEmployee)
                .HasPrecision(1, 1)
                .IsRequired();
            
            builder.Property(p => p.DateStart)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.DateEnd)
                .HasColumnType("date")
                .IsRequired(false);

            builder.HasOne(p => p.Position)
                .WithMany(p => p.Assignments)
                .HasForeignKey(p => p.PositionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Employee)
                .WithMany(p => p.Assignments)
                .HasForeignKey(p => p.EmployeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}