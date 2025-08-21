using System.Text.Json.Serialization;

namespace Screen_Sound.Models;

internal class Musica
{
    public Musica() { }
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public int Id { get; set; }
    public Banda Artista { get; }
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string NomeArtista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string Genero { get; set; }
    public DateOnly? DataLancamento { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida { get { return $"A musica {Nome} e do artista {NomeArtista}"; } }

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine(Disponivel ? "A musica esta disponivel no plano" : "Musica não disponivel no plano.");
    }

    public void EscreveDisponivel(bool value)
    {
        Disponivel = value;
    }

    public bool LeDisponivel()
    {
        return Disponivel;
    }
    public void ExibirDetalhesMusica()
    {
        Console.WriteLine(@$"Nome da musica: {Nome}
Artista: {NomeArtista}
Duração: {Duracao / 1000}
Genero: {Genero}");
    }
}
