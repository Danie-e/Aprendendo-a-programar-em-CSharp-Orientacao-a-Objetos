using Microsoft.Data.SqlClient;
using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class BandaDAl
{
    public BandaDAl(ScreenSoundContext context)
    {
        this.context = context;
    }

    private readonly ScreenSoundContext context;


    public IEnumerable<Banda> Listar()
    {
        return context.Bandas.ToList();
    }

    public void Inserir(Banda banda)
    {
        context.Bandas.Add(banda);
        context.SaveChanges();
        Console.WriteLine($"Banda {banda.Nome} inserida com sucesso.");
    }

    public void Atualizar(Banda banda)
    {
        context.Bandas.Update(banda);
        context.SaveChanges();
        Console.WriteLine($"Banda {banda.Nome} atualizada com sucesso.");
    }
    public void Deletar(Banda banda)
    {
        context.Bandas.Remove(banda);
        context.SaveChanges();
        Console.WriteLine($"Foram deletada a {banda.Nome} na tabela Artistas.");
    }
}
