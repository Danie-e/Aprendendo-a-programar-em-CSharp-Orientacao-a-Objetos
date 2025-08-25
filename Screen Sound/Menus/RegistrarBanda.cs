
using Screen_Sound.Banco;
using Screen_Sound.Models;

namespace Screen_Sound.Menus;

internal class RegistrarBanda : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        ExibirTituloDaOpcao("Registro de Bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.Write("Digite a biografia da banda que deseja registrar: ");
        string bioDaBanda = Console.ReadLine()!;
        bandaDAL.Inserir(new Banda(nomeDaBanda, bioDaBanda));
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

        Thread.Sleep(2000);
        Console.Clear();
    }
}
