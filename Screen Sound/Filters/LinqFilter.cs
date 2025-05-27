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

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        List<string> artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.NomeArtista).Distinct().ToList();

        Console.WriteLine($"Artistas econtrados do genero {genero}:");

        foreach (string artista in artistasPorGenero)
            Console.WriteLine($"- {artista}");
    }
    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        List<Musica> musicasArtista = musicas.Where(musica => musica.NomeArtista.Equals(artista)).ToList();
        Console.WriteLine($"Musicas encontradas do artista {artista}");
        foreach (Musica musica in musicasArtista)
        {
            musica.ExibirDetalhesMusica();
        }
    }
}
