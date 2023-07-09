using Microsoft.EntityFrameworkCore.Migrations;

namespace EmlakEF.Migrations
{
    public partial class tblUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
