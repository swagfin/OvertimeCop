using Microsoft.EntityFrameworkCore.Migrations;

namespace OvertimeCop.Migrations
{
    public partial class ModifiedOvertimeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Overtimes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Overtimes_EmployeeId",
                table: "Overtimes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Overtimes_Employees_EmployeeId",
                table: "Overtimes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overtimes_Employees_EmployeeId",
                table: "Overtimes");

            migrationBuilder.DropIndex(
                name: "IX_Overtimes_EmployeeId",
                table: "Overtimes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Overtimes");
        }
    }
}
