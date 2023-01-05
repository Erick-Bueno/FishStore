using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class fishstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokenss",
                table: "Tokenss");

            migrationBuilder.RenameTable(
                name: "Tokenss",
                newName: "Tokens");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokens",
                table: "Tokens",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokens",
                table: "Tokens");

            migrationBuilder.RenameTable(
                name: "Tokens",
                newName: "Tokenss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokenss",
                table: "Tokenss",
                column: "id");
        }
    }
}
