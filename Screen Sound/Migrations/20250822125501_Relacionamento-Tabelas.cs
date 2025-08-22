using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Screen_Sound.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_Bandas_BandaId",
                table: "Albuns");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Bandas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "Avaliacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BandaId",
                table: "Albuns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_Bandas_BandaId",
                table: "Albuns",
                column: "BandaId",
                principalTable: "Bandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_Bandas_BandaId",
                table: "Albuns");

            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Avaliacao");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Bandas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BandaId",
                table: "Albuns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_Bandas_BandaId",
                table: "Albuns",
                column: "BandaId",
                principalTable: "Bandas",
                principalColumn: "Id");
        }
    }
}
