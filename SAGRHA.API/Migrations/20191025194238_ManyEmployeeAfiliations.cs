using Microsoft.EntityFrameworkCore.Migrations;

namespace SAGRHA.API.Migrations
{
    public partial class ManyEmployeeAfiliations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Insurances_InsuranceId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PensionFunds_PensionFundId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_InsuranceId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PensionFundId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CuaNumber",
                table: "PensionFunds");

            migrationBuilder.DropColumn(
                name: "InsuranceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PensionFundId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "Affiliations",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    PensionFundId = table.Column<int>(nullable: false),
                    NuaNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affiliations", x => new { x.EmployeeId, x.PensionFundId });
                    table.ForeignKey(
                        name: "FK_Affiliations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Affiliations_PensionFunds_PensionFundId",
                        column: x => x.PensionFundId,
                        principalTable: "PensionFunds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceContracts",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    InsuranceCatalogId = table.Column<int>(nullable: false),
                    Enrollment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceContracts", x => new { x.EmployeeId, x.InsuranceCatalogId });
                    table.ForeignKey(
                        name: "FK_InsuranceContracts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsuranceContracts_Insurances_InsuranceCatalogId",
                        column: x => x.InsuranceCatalogId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affiliations_PensionFundId",
                table: "Affiliations",
                column: "PensionFundId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceContracts_InsuranceCatalogId",
                table: "InsuranceContracts",
                column: "InsuranceCatalogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Affiliations");

            migrationBuilder.DropTable(
                name: "InsuranceContracts");

            migrationBuilder.AddColumn<string>(
                name: "CuaNumber",
                table: "PensionFunds",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PensionFundId",
                table: "Employees",
                nullable: true);

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
    }
}
