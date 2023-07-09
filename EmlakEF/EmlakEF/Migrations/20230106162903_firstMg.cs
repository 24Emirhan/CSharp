using Microsoft.EntityFrameworkCore.Migrations;

namespace EmlakEF.Migrations
{
    public partial class firstMg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmlak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanNo = table.Column<int>(type: "int", nullable: false),
                    OdaSayisi = table.Column<int>(type: "int", nullable: false),
                    KatNo = table.Column<int>(type: "int", nullable: false),
                    Alan = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, defaultValue: "alan"),
                    Semt = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, defaultValue: "semt")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmlak", x => x.Id);
                });
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmlak");

            
        }
    }
}
