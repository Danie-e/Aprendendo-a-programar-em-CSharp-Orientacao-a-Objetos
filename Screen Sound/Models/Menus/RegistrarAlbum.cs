
namespace Screen_Sound.Models.Menus;

internal class RegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTituloDaOpcao("Registrar album da banda");
        Console.Write("Digite o nome da banda que deseja cadastrar novo album: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("Digite o nome do album: ");
            string nomeAlbum = Console.ReadLine()!;
            bandasRegistradas[nomeBanda].AdicionarAlbum(new(nomeAlbum));
        }

        Console.WriteLine($"O album da banda {nomeBanda} foi registrado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
