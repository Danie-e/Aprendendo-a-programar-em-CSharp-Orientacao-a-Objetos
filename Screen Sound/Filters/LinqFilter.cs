using Screen_Sound.Models;

namespace Screen_Sound.Filters;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        List<string> generos = musicas.Select(musica => musica.Genero).Distinct().ToList();

        Console.WriteLine($"\nGeneros musicais encontrados:");
                foreach (string genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
