
namespace Screen_Sound.Models.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTituloDaOpcao("Exibir media da banda");

        Console.Write("Digite o nome da banda que voce deseja saber a nota: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.WriteLine("Discografia");
            Console.WriteLine($"A media das notas da banda {nomeBanda} é: {bandasRegistradas[nomeBanda].Media:f2}.\n");
            foreach (Album album in bandasRegistradas[nomeBanda].ListaDeAlbuns)
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
