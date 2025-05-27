using System.Net.Http.Json;
using System.Text.Json;

namespace Screen_Sound.Models;

internal class MusicasPreferidas
{
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public List<Musica> ListaDeMusicasFavoritas { get; } = new();

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void EscrevaMusicasFavoritas()
    {
        Console.WriteLine($"Estas são as musicas favoriatas de {Nome}");
        foreach (Musica musica in ListaDeMusicasFavoritas)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"O arquivo foi criado com sucesso. {Path.GetFullPath(nomeArquivo)}");
    }
}
