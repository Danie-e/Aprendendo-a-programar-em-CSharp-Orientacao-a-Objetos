namespace Screen_Sound.Models;

internal class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    public List<Album> ListaDeAlbuns { get; set; } = new();
    public List<int> notas { get;  } = new();
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        ListaDeAlbuns.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in ListaDeAlbuns)
        {
            Console.WriteLine($"O album {album.Nome} possue duração: {album.DuracaoTotal} segundos.");
        }
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }
}
