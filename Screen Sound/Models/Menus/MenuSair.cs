using Screen_Sound.Banco;

namespace Screen_Sound.Models.Menus;

internal class MenuSair : Menu
{
    public override void Executar(BandaDAl bandaDAL)
    {
        Console.WriteLine($"Tchau Tchau.");
    }
}
