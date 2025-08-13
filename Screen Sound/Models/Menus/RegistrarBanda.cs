
using Screen_Sound.Banco;

namespace Screen_Sound.Models.Menus;

internal class RegistrarBanda : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        ExibirTituloDaOpcao("Registro de Bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandaDAL.Inserir(new Banda(nomeDaBanda));
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

        Thread.Sleep(2000);
        Console.Clear();
    }
}
