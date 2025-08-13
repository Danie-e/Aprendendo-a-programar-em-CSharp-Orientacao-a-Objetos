
using Screen_Sound.Banco;

namespace Screen_Sound.Models.Menus;

internal class AvaliarBanda : Menu
{
    public override void Executar(BandaDAl bandaDAL)
    {
        ExibirTituloDaOpcao("Avaliar Banda");

        Console.Write("Digite o nome da banda que voce deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        List<Banda> bandasRegistradas = bandaDAL.Listar().ToList();
        Banda banda = bandasRegistradas.FirstOrDefault(banda => banda.Nome == nomeBanda);

        if (banda is not null)
        {
            Console.Write($"Digite sua nota para a banda {nomeBanda}");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.Write($"Nota registrada com sucesso!");
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi encontrada, digite qualque tecla para voltar ao menu principal.");
            Console.ReadKey();
        }

        Thread.Sleep(1000);
        Console.Clear();
    }
}
