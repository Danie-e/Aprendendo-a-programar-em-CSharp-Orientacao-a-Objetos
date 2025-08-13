namespace Screen_Sound.Models;

internal class Banda : IAvaliavel
{
    public Banda() { }
    public Banda(string nome)
    {
        Nome = nome;
    }

    public List<Album> ListaDeAlbuns { get; set; } = new();
    public List<Avaliacao> notas { get; } = new();

    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            return notas.Average(i => i.Nota);
        }
    }

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

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public override string ToString()
    {
        return $@"
Banda: {Nome}, 
Biografia: {Bio},
Média de Avaliações: {Media:F2}";
    }
}
