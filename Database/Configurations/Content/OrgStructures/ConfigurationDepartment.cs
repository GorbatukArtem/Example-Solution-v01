using Database.Models.Content.OrgStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgStructures
{
    public class ConfigurationDepartment : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "dbo.Content.OrgStructures");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(p => p.Name)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.DateStart)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.DateEnd)
                .HasColumnType("date")
                .IsRequired(false);

            builder.HasOne(p => p.Company)
                .WithMany(p => p.Departments)
                .HasForeignKey(p => p.CompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Рекурсия
            builder.HasOne(p => p.ParentDepartment)
                .WithMany(p => p.Teams)
                .HasForeignKey(p => p.ParentDepartmentId)
                .HasConstraintName("FK_Departments_Teams_DepartmentId");
        }
    }
}