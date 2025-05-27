namespace Screen_Sound.Models;

internal class MusicasPreferidas
{
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public List<Musica> ListaDeMusicasFavoritas { get; } = new();

    public void adicionarMusicaFavorita(Musica musica)
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
}
