
using Screen_Sound.Banco;

namespace Screen_Sound.Models.Menus;

internal class MostrarBandasRegistradas : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        ExibirTituloDaOpcao("Exibindo nome de todas as bandas registradas.");

        foreach (Banda banda in bandaDAL.Listar())
            Console.WriteLine(banda.ToString());

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();

        Thread.Sleep(1000);
        Console.Clear();
    }
}
