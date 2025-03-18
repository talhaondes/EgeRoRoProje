using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anasayfaFoto",
                table: "Galleries");

            migrationBuilder.AddColumn<string>(
                name: "GemiUrl",
                table: "Fleets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gemino",
                table: "Fleets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GemiUrl",
                table: "Fleets");

            migrationBuilder.DropColumn(
                name: "Gemino",
                table: "Fleets");

            migrationBuilder.AddColumn<string>(
                name: "anasayfaFoto",
                table: "Galleries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
