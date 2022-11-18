using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomonesToDoListApp.Infrastrcuture.Migrations
{
    public partial class FixSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.ToDo",
                table: "dbo.ToDo");

            migrationBuilder.RenameTable(
                name: "dbo.ToDo",
                newName: "ToDo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDo",
                table: "ToDo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDo",
                table: "ToDo");

            migrationBuilder.RenameTable(
                name: "ToDo",
                newName: "dbo.ToDo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.ToDo",
                table: "dbo.ToDo",
                column: "Id");
        }
    }
}
