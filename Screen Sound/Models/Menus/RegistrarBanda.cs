
namespace Screen_Sound.Models.Menus;

internal class RegistrarBanda:Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTituloDaOpcao("Registro de Bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new(nomeDaBanda));
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

        Thread.Sleep(2000);
        Console.Clear();
    }
}
