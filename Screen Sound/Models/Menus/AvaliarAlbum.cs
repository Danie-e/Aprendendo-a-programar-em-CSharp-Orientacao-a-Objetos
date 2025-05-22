
using System.Linq;

namespace Screen_Sound.Models.Menus;

internal class AvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Banda");

        Console.Write("Digite o nome da banda que voce deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("Digite o nome do album que voce deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;
            Album album = bandasRegistradas[nomeBanda].ListaDeAlbuns.FirstOrDefault(i => i.Nome == nomeAlbum);
            if (album is not null)
            {
                Console.Write($"Digite sua nota para o album {nomeAlbum}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

                album.AdicionarNota(nota);
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
