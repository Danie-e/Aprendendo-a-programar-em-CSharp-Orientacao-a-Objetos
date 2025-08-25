
using Screen_Sound.Banco;
using Screen_Sound.Models;

namespace Screen_Sound.Menus;

internal class AvaliarAlbum : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        base.Executar(bandaDAL);
        ExibirTituloDaOpcao("Avaliar Banda");

        Console.Write("Digite o nome da banda que voce deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda? banda = bandaDAL.ObterPor(banda => banda.Nome == nomeBanda);

        if (banda is not null)
        {
            Console.Write("Digite o nome do album que voce deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;
            Album album = banda.ListaDeAlbuns.FirstOrDefault(i => i.Nome == nomeAlbum);
            if (album is not null)
            {
                DAL<Avaliacao> avaliacaoDAL = new(new ScreenSoundContext());
                Console.Write($"Digite sua nota para o album {nomeAlbum}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

                nota.AlbumId = album.Id;
                avaliacaoDAL.Inserir(nota);

                Console.Write($"Nota registrada com sucesso!");
            }
            else
            {
                Console.WriteLine($"O album {nomeAlbum} não foi encontrada, digite qualque tecla para voltar ao menu principal.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi encontrada, digite qualque tecla para voltar ao menu principal.");
            Console.ReadKey();
        }

        Thread.Sleep(1000);
        Console.Clear();
    }
}
