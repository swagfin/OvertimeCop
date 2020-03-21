using Microsoft.EntityFrameworkCore.Migrations;

namespace OvertimeCop.Migrations
{
    public partial class ModifiedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Employees");
            migrationBuilder.Sql("DELETE FROM Departments");
            migrationBuilder.Sql("DELETE FROM Overtimes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
