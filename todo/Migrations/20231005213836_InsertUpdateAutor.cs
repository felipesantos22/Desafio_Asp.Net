using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo.Migrations
{
    /// <inheritdoc />
    public partial class InsertUpdateAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "autor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_autor",
                table: "autor",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_autor",
                table: "autor");

            migrationBuilder.RenameTable(
                name: "autor",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }
    }
}
