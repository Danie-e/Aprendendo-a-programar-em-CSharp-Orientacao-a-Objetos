namespace Screen_Sound.Models;

public class Banda : IAvaliavel
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    public virtual List<Album> ListaDeAlbuns { get; set; } = new();
    public List<Avaliacao> notas { get; set; } = new();

    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }
    public string Nome { get; set; }
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
