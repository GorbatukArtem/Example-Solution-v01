// <auto-generated />
using System;
using Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(DbContextMySolution))]
    [Migration("20210825164640_Change003")]
    partial class Change003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Companies", "dbo.Content.OrgStructures");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ParentDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParentDepartmentId");

                    b.ToTable("Departments", "dbo.Content.OrgStructures");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("date");

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Positions", "dbo.Content.OrgStructures");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Department", b =>
                {
                    b.HasOne("Database.Models.Content.OrgStructures.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Database.Models.Content.OrgStructures.Department", "ParentDepartment")
                        .WithMany("Teams")
                        .HasForeignKey("ParentDepartmentId")
                        .HasConstraintName("FK_Departments_Teams_DepartmentId");

                    b.Navigation("Company");

                    b.Navigation("ParentDepartment");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Position", b =>
                {
                    b.HasOne("Database.Models.Content.OrgStructures.Department", "Department")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Database.Models.Content.OrgStructures.Position", "Manager")
                        .WithMany("Subordinates")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK_Manager_Subordinates_ManagerId");

                    b.Navigation("Department");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Company", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Department", b =>
                {
                    b.Navigation("Positions");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Database.Models.Content.OrgStructures.Position", b =>
                {
                    b.Navigation("Subordinates");
                });
#pragma warning restore 612, 618
        }
    }
}
