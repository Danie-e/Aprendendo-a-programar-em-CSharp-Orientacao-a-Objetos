
namespace Screen_Sound.Models.Menus;

internal class MostrarBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTituloDaOpcao("Exibindo nome de todas as bandas registradas.");

        //for (int i = 0; i < listaDeBandas.Count; i++)
        //    Console.WriteLine($"Banda: {listaDeBandas[i]}");

        foreach (string banda in bandasRegistradas.Keys)
            Console.WriteLine($"Banda: {banda}");


        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();

        Thread.Sleep(1000);
        Console.Clear();
    }
}
