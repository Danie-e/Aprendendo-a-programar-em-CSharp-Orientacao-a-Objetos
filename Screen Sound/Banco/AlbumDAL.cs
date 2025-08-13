using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class AlbumDAL : DAL<Album>
{
    public AlbumDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    private readonly ScreenSoundContext context;


    public override IEnumerable<Album> Listar()
    {
        return context.Albuns.ToList();
    }

    public override void Inserir(Album album)
    {
        context.Albuns.Add(album);
        context.SaveChanges();
        Console.WriteLine($"Album {album.Nome} inserida com sucesso.");
    }

    public override void Atualizar(Album album)
    {
        context.Albuns.Update(album);
        context.SaveChanges();
        Console.WriteLine($"Album {album.Nome} atualizada com sucesso.");
    }
    public override void Deletar(Album album)
    {
        context.Albuns.Remove(album);
        context.SaveChanges();
        Console.WriteLine($"Foram deletada a {album.Nome} na tabela Album.");
    }
}
