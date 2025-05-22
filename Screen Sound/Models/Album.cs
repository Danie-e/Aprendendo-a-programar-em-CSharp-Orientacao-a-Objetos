namespace Screen_Sound.Models;

internal class Album : IAvaliavel
{
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => MusicasAlbum.Sum(i => i.Duracao);
    private List<Avaliacao> Notas { get; } = new();
    public double Media
    {
        get
        {
            if (Notas.Count == 0) return 0;
            else return Notas.Average(a => a.Nota);
        }
    }
    private List<Musica> MusicasAlbum { get; set; } = new();

    public void AdicionarMusica(Musica musica)
    {
        MusicasAlbum.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        Notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Listas de musicas do album: {Nome}");
        foreach (Musica musica in MusicasAlbum)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouir este album inteiro você precisa de {DuracaoTotal} segundos.");
    }
}
