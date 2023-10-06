using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo.Migrations
{
    /// <inheritdoc />
    public partial class InsertUpdateObra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tarefas",
                newName: "Publicacao");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "tarefas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Exposicao",
                table: "tarefas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "tarefas");

            migrationBuilder.DropColumn(
                name: "Exposicao",
                table: "tarefas");

            migrationBuilder.RenameColumn(
                name: "Publicacao",
                table: "tarefas",
                newName: "Email");
        }
    }
}
