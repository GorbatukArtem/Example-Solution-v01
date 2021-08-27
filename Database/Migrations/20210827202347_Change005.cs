using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Change005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo.Content.HumanResources");

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "dbo.Content.HumanResources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FullTimeEmployee = table.Column<double>(type: "float", nullable: false),
                    BirthDay = table.Column<byte>(type: "tinyint", nullable: true),
                    BirthMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    DateStart = table.Column<DateTime>(type: "date", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_EmployeeId",
                schema: "dbo.Content.OrgPositions",
                table: "Assignments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityId",
                schema: "dbo.Content.HumanResources",
                table: "Employees",
                column: "IdentityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Employees_EmployeeId",
                schema: "dbo.Content.OrgPositions",
                table: "Assignments",
                column: "EmployeeId",
                principalSchema: "dbo.Content.HumanResources",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Employees_EmployeeId",
                schema: "dbo.Content.OrgPositions",
                table: "Assignments");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "dbo.Content.HumanResources");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_EmployeeId",
                schema: "dbo.Content.OrgPositions",
                table: "Assignments");
        }
    }
}
