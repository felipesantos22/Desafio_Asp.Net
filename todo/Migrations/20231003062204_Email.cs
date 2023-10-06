using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo.Migrations
{
    /// <inheritdoc />
    public partial class Email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "tarefas");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tarefas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tarefas",
                table: "tarefas",
                column: "TarefaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tarefas",
                table: "tarefas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tarefas");

            migrationBuilder.RenameTable(
                name: "tarefas",
                newName: "Tarefas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "TarefaId");
        }
    }
}
