using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myProject.Migrations
{
    public partial class AtualizaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "ususario");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "ususario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ususario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "ususario",
                newName: "data_nascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ususario",
                table: "ususario",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ususario",
                table: "ususario");

            migrationBuilder.RenameTable(
                name: "ususario",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Usuarios",
                newName: "DataNascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
