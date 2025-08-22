namespace Screen_Sound.Models;

public class Album : IAvaliavel
{
    public Album() { }
    public Album(string nome, int bandaId)
    {
        Nome = nome;
        BandaId = bandaId;
    }
    public int BandaId { get; set; }
    public int Id { get; set; }
    public string Nome { get; set; }
    public int DuracaoTotal => MusicasAlbum.Sum(i => i.Duracao);
    public virtual List<Avaliacao> Notas { get; set; } = new();
    public double Media
    {
        get
        {
            if (Notas.Count == 0) return 0;
            else return Notas.Average(a => a.Nota);
        }
    }
    public virtual List<Musica> MusicasAlbum { get; set; } = new();

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
