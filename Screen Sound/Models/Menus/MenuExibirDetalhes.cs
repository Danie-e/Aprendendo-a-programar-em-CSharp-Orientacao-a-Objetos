
using Screen_Sound.Banco;

namespace Screen_Sound.Models.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(BandaDAl bandaDAL)
    {
        ExibirTituloDaOpcao("Exibir media da banda");

        Console.Write("Digite o nome da banda que voce deseja saber a nota: ");
        string nomeBanda = Console.ReadLine()!;
        List<Banda> bandasRegistradas = bandaDAL.Listar().ToList();
        Banda banda = bandasRegistradas.FirstOrDefault(banda => banda.Nome == nomeBanda);
        if (banda is not null)
        //if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.WriteLine("Discografia");
            Console.WriteLine($"A media das notas da banda {nomeBanda} é: {banda.Media:f2}.\n");
            foreach (Album album in banda.ListaDeAlbuns)
            {
                Console.WriteLine($"A media das notas do album {album.Nome} é: {album.Media:f2}.\n");
            }
        }
        else
            Console.WriteLine($"Não foi possivel encontrar a banda {nomeBanda}.");

        Console.WriteLine($"Digite qualque tecla para voltar ao menu principal.");

        Console.ReadKey();
        Thread.Sleep(1000);
        Console.Clear();

    }
}
