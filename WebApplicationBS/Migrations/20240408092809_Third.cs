using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationBS.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipos",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipos",
                table: "Equipos",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipos",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Equipos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipos",
                table: "Equipos",
                column: "Nombre");
        }
    }
}
