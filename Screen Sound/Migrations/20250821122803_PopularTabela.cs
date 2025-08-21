using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Screen_Sound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Bandas",
                new[] { "Nome", "FotoPerfil", "Bio" },
                new object[,]
                {
                    {"Imagine Dragons", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8ca1Cl_LOxgD-jYlOSf2XA_J8viLtACorTw&s", "Imagine Dragons é uma banda de pop rock formada em Las Vegas nos Estados Unidos, consistindo do vocalista Dan Reynolds, do guitarrista Wayne Sermon e do baixista Ben McKee. " },
                    {"Hozier", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQ0_voZ45CqOcfZT16B20Fwv48fLrtClbmmOxuFR4AtPGVy94nhlF1xfvLrUt9SuPg8I9WuiFv9XrwezhX3ds06jrummUBnLwFRNOV6GOgmag", "Andrew John Hozier-Byrne, mais conhecido como Hozier, é um cantor, compositor e músico irlandês. Hozier é originário de Bray, Condado de Wicklow." },
                    {"Artemas", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcS4x95i322j_zHjyRyvI6RXQB4JJh0-MlSsn68rJ0mh9ql5YEqsxo3Wq-g3mXsCObF-4_XjfVtd2hIu3VUNqtykRFDogDlFuGbdMKsIB8jf", "Artemas Diamandis conhecido profissionalmente como Artemas é um cantor, compositor e produtor musical cipriota inglês. Ele é mais conhecido por seus singles \"If U Think I'm Pretty\" e \"I Like the Way You Kiss Me\" que ficaram famosos no inicio de 2024.." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Bandas ");
        }
    }
}
