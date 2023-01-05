using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class exec3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usuariosCS",
                table: "usuariosCS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tokenCS",
                table: "tokenCS");

            migrationBuilder.RenameTable(
                name: "usuariosCS",
                newName: "clientes");

            migrationBuilder.RenameTable(
                name: "tokenCS",
                newName: "Tokenss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokenss",
                table: "Tokenss",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokenss",
                table: "Tokenss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.RenameTable(
                name: "Tokenss",
                newName: "tokenCS");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "usuariosCS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tokenCS",
                table: "tokenCS",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuariosCS",
                table: "usuariosCS",
                column: "id");
        }
    }
}
