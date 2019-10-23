using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SAGRHA.API.Migrations
{
    public partial class ExtendEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AFP",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CUA",
                table: "Employees");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InsuranceId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PensionFundId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PensionFunds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CuaNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionFunds", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_InsuranceId",
                table: "Employees",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PensionFundId",
                table: "Employees",
                column: "PensionFundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Insurances_InsuranceId",
                table: "Employees",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PensionFunds_PensionFundId",
                table: "Employees",
                column: "PensionFundId",
                principalTable: "PensionFunds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Insurances_InsuranceId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PensionFunds_PensionFundId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "PensionFunds");

            migrationBuilder.DropIndex(
                name: "IX_Employees_InsuranceId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PensionFundId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "InsuranceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PensionFundId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "AFP",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CUA",
                table: "Employees",
                nullable: true);
        }
    }
}
