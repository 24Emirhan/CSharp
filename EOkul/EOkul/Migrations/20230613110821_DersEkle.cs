using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EOkul.Migrations
{
    /// <inheritdoc />
    public partial class DersEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, defaultValue: "Adi"),
                    Numarasi = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, defaultValue: "Numarasi"),
                    MatOrt = table.Column<double>(type: "float", nullable: false),
                    FizikOrt = table.Column<double>(type: "float", nullable: false),
                    BiyolojiOrt = table.Column<double>(type: "float", nullable: false),
                    KimyaOrt = table.Column<double>(type: "float", nullable: false),
                    TurkceOrt = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblKullanici",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, defaultValue: "KullaniciAdi"),
                    Sifre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, defaultValue: "Sifre")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblKullanici", x => x.KullaniciId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblDers");

            migrationBuilder.DropTable(
                name: "tblKullanici");
        }
    }
}
