using Microsoft.EntityFrameworkCore.Migrations;

namespace OvertimeCop.Migrations
{
    public partial class AddedTotalAmtInOvertime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalAmount",
                table: "Overtimes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Overtimes");
        }
    }
}
