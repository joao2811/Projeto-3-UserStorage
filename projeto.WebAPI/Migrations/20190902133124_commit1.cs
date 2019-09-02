using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto.WebAPI.Migrations
{
    public partial class commit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameAccounts",
                columns: table => new
                {
                    Account_ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Account_Username = table.Column<string>(nullable: true),
                    Account_Email = table.Column<string>(nullable: true),
                    Account_Birthday = table.Column<string>(nullable: true),
                    Account_Password = table.Column<string>(nullable: true),
                    Account_Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameAccounts", x => x.Account_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameAccounts");
        }
    }
}
