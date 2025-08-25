using Screen_Sound.Banco;
using Screen_Sound.Models;

namespace Screen_Sound.Menus;

internal class AvaliarBanda : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        ExibirTituloDaOpcao("Avaliar Banda");

        Console.Write("Digite o nome da banda que voce deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda? banda = bandaDAL.ObterPor(banda => banda.Nome == nomeBanda);

        if (banda is not null)
        {
            DAL<Avaliacao> avaliacaoDAL = new DAL<Avaliacao>(new ScreenSoundContext());
            Console.Write($"Digite sua nota para a banda {nomeBanda}: ");
           
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            nota.BandaId = banda.Id;
            avaliacaoDAL.Inserir(nota);

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
