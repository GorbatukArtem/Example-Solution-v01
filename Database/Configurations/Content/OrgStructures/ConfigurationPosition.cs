using Database.Models.Content.OrgStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgStructures
{
    public class ConfigurationPosition : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Positions", "dbo.Content.OrgStructures");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(p => p.Name)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(p => p.DateStart)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.DateEnd)
                .HasColumnType("date")
                .IsRequired(false);

            builder.HasOne(p => p.Department)
                .WithMany(p => p.Positions)
                .HasForeignKey(p => p.DepartmentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Рекурсия
            builder.HasOne(p => p.Manager)
                .WithMany(p => p.Subordinates)
                .HasForeignKey(p => p.ManagerId)
                .HasConstraintName("FK_Manager_Subordinates_ManagerId");
        }
    }
}