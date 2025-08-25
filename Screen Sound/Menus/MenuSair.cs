using Screen_Sound.Banco;
using Screen_Sound.Models;

namespace Screen_Sound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        Console.WriteLine($"Tchau Tchau.");
    }
}
