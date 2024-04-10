using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationBS.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Misiones",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperativoID",
                table: "Misiones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Misiones_Id",
                table: "Misiones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Misiones_Operativos_Id",
                table: "Misiones",
                column: "Id",
                principalTable: "Operativos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Misiones_Operativos_Id",
                table: "Misiones");

            migrationBuilder.DropIndex(
                name: "IX_Misiones_Id",
                table: "Misiones");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Misiones");

            migrationBuilder.DropColumn(
                name: "OperativoID",
                table: "Misiones");
        }
    }
}
