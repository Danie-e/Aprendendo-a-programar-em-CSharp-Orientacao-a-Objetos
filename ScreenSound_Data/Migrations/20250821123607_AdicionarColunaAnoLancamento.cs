using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Screen_Sound.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarColunaAnoLancamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataLancamento",
                table: "Musica",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataLancamento",
                table: "Musica");
        }
    }
}
