using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tarefas",
                newName: "TarefaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TarefaId",
                table: "Tarefas",
                newName: "Id");
        }
    }
}
