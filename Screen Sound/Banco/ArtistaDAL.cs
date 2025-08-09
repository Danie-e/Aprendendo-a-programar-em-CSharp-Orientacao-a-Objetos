using Microsoft.Data.SqlClient;
using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class ArtistaDAL
{
    public ArtistaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    private readonly ScreenSoundContext context;


    public IEnumerable<Artista> Listar()
    {
        return context.Artistas.ToList();
    }

    public void Inserir(Artista banda)
    {
        context.Artistas.Add(banda);
        context.SaveChanges();
        Console.WriteLine($"Banda {banda.Nome} inserida com sucesso.");
    }

    public void Atualizar(Artista banda)
    {
        context.Artistas.Update(banda);
        context.SaveChanges();
        Console.WriteLine($"Banda {banda.Nome} atualizada com sucesso.");
    }
    public void Deletar(Artista banda)
    {
        context.Artistas.Remove(banda);
        context.SaveChanges();
        Console.WriteLine($"Foram deletada a {banda.Nome} na tabela Artistas.");
    }
}
