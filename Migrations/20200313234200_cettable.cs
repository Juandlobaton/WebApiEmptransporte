using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiEmptransporte.Migrations
{
    public partial class cettable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_propietario",
                table: "conductors");

            migrationBuilder.AddColumn<string>(
                name: "Id_vehiculo",
                table: "conductors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_vehiculo",
                table: "conductors");

            migrationBuilder.AddColumn<string>(
                name: "Id_propietario",
                table: "conductors",
                type: "text",
                nullable: true);
        }
    }
}
