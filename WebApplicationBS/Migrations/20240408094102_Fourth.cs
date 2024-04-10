using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationBS.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Misiones_Operativos_Id",
                table: "Misiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operativos",
                table: "Operativos");

            migrationBuilder.DropIndex(
                name: "IX_Misiones_Id",
                table: "Misiones");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Operativos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Misiones");

            migrationBuilder.DropColumn(
                name: "OperativoID",
                table: "Misiones");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Operativos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "NombreOperativo",
                table: "Misiones",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operativos",
                table: "Operativos",
                column: "Nombre");

            migrationBuilder.CreateIndex(
                name: "IX_Misiones_NombreOperativo",
                table: "Misiones",
                column: "NombreOperativo");

            migrationBuilder.AddForeignKey(
                name: "FK_Misiones_Operativos_NombreOperativo",
                table: "Misiones",
                column: "NombreOperativo",
                principalTable: "Operativos",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Misiones_Operativos_NombreOperativo",
                table: "Misiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operativos",
                table: "Operativos");

            migrationBuilder.DropIndex(
                name: "IX_Misiones_NombreOperativo",
                table: "Misiones");

            migrationBuilder.DropColumn(
                name: "NombreOperativo",
                table: "Misiones");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Operativos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Operativos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operativos",
                table: "Operativos",
                column: "Id");

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
    }
}
