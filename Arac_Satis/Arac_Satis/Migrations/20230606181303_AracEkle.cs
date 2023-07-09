using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arac_Satis.Migrations
{
    /// <inheritdoc />
    public partial class AracEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblArac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanNo = table.Column<int>(type: "int", nullable: false),
                    Marka = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, defaultValue: "marka"),
                    Model = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, defaultValue: "model"),
                    Kilometre = table.Column<double>(type: "float", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    Tramer = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, defaultValue: "UserName"),
                    Password = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, defaultValue: "Password")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblArac");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
