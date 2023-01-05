using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class exce2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "usuariosCS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuariosCS",
                table: "usuariosCS",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usuariosCS",
                table: "usuariosCS");

            migrationBuilder.RenameTable(
                name: "usuariosCS",
                newName: "usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "id");
        }
    }
}
