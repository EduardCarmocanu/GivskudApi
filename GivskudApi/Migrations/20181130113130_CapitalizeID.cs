using Microsoft.EntityFrameworkCore.Migrations;

namespace GivskudApi.Migrations
{
    public partial class CapitalizeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markers_Descriptions_DescriptionId",
                table: "Markers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MarkerTypes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DescriptionId",
                table: "Markers",
                newName: "DescriptionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Markers",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Markers_DescriptionId",
                table: "Markers",
                newName: "IX_Markers_DescriptionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Descriptions",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Markers_Descriptions_DescriptionID",
                table: "Markers",
                column: "DescriptionID",
                principalTable: "Descriptions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markers_Descriptions_DescriptionID",
                table: "Markers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MarkerTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DescriptionID",
                table: "Markers",
                newName: "DescriptionId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Markers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Markers_DescriptionID",
                table: "Markers",
                newName: "IX_Markers_DescriptionId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Descriptions",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Markers_Descriptions_DescriptionId",
                table: "Markers",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
