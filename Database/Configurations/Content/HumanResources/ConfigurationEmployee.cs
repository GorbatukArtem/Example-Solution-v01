using Database.Models.Content.HumanResources;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.HumanResources
{
    public class ConfigurationEmployee : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees", "dbo.Content.HumanResources");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(p => p.IdentityId)
                .IsUnique();

            builder.Property(p => p.IdentityId)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Photo)
                .IsRequired();

            builder.Property(p => p.FullTimeEmployee)
                .IsRequired();

            builder.Property(p => p.BirthDay)
                .IsRequired(false);

            builder.Property(p => p.BirthMonth)
                .IsRequired(false);

            builder.Property(p => p.DateStart)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.DateEnd)
                .HasColumnType("date")
                .IsRequired(false);
        }
    }
}