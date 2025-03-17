using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUss",
                columns: table => new
                {
                    AboutUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimizdaBaslik1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaBaslik2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaAciklama1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaAciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anasayfaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUss", x => x.AboutUsId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iletisimBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anasayfaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    CrewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ekipBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ekipDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ekipFoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.CrewId);
                });

            migrationBuilder.CreateTable(
                name: "Expertices",
                columns: table => new
                {
                    ExperticeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uzmanlikBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uzmanlikDetay1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uzmanlikDetay2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uzmanlikDetay3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uzmanlikFoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertices", x => x.ExperticeId);
                });

            migrationBuilder.CreateTable(
                name: "Fleets",
                columns: table => new
                {
                    FleetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FiloBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiBayrak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiKapasite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiBoy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiGrt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GemiDwt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fleets", x => x.FleetId);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    GalleryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    galeriFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anasayfaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.GalleryId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetIcon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUss");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Expertices");

            migrationBuilder.DropTable(
                name: "Fleets");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
