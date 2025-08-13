using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class BandaDAl : DAL<Banda>
{
    public BandaDAl(ScreenSoundContext context)
    {
        this.context = context;
    }

    private readonly ScreenSoundContext context;


    public override IEnumerable<Banda> Listar()
    {
        return context.Bandas.ToList();
    }

    public override void Inserir(Banda banda)
    {
        context.Bandas.Add(banda);
        context.SaveChanges();
        Console.WriteLine($"Banda {banda.Nome} inserida com sucesso.");
    }

    public override void Atualizar(Banda banda)
    {
        context.Bandas.Update(banda);
        context.SaveChanges();
        Console.WriteLine($"Banda {banda.Nome} atualizada com sucesso.");
    }
    public override void Deletar(Banda banda)
    {
        context.Bandas.Remove(banda);
        context.SaveChanges();
        Console.WriteLine($"Foram deletada a {banda.Nome} na tabela Banda.");
    }
}
