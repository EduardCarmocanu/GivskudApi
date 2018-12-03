using Microsoft.EntityFrameworkCore.Migrations;

namespace GivskudApi.Migrations
{
    public partial class DecimalPrecision15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Lng",
                table: "Markers",
                type: "decimal(18, 15)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Markers",
                type: "decimal(18, 15)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Lng",
                table: "Markers",
                type: "decimal(18, 8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 15)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Markers",
                type: "decimal(18, 8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 15)");
        }
    }
}
