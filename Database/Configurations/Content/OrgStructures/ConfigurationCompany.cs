﻿using Database.Models.Content.OrgStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Content.OrgStructures
{
    public class ConfigurationCompany : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies", "dbo.Content.OrgStructure");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.DateStart)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.DateEnd)
                .HasColumnType("date")
                .IsRequired(false);
        }
    }
}