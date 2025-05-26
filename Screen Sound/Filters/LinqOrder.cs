using Screen_Sound.Models;

namespace Screen_Sound.Filters;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        List<string> artistas = musicas.OrderBy(musica => musica.NomeArtista).Select(musica => musica.NomeArtista).Distinct().ToList();

        Console.WriteLine("Artistas encontrados: ");

        foreach (string nomeArista in artistas)
            Console.WriteLine($"- {nomeArista}");
    }
}
