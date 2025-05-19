
using Screen_Sound.Models;


Musica musica1 = new Musica();
musica1.Artista = "Queen";
musica1.Nome = "Love of my life";
musica1.Duracao = 273;

Musica musica2 = new Musica();
musica2.Artista = "Queen";
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 275;

Album AlbumDoQueen = new Album();
AlbumDoQueen.Nome = "A Night at the Opera";
AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);
//AlbumDoQueen.ExibirMusicasDoAlbum();

Banda Queen = new Banda();
Queen.Nome = "Queen";
Queen.AdicionarAlbum(AlbumDoQueen);
Queen.ExibirDiscografia();


Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("U2", new() { 1, 4, 8 });
bandasRegistradas.Add("Imagine Dragons", new() { 10, 5, 3 });

void ExibirLogo()
{
    string mensagemDeBoasVinda = @"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
    Console.WriteLine(mensagemDeBoasVinda);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para exibir todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir media de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("Digite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaBanda();
            break;
        default:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}.");
            Console.WriteLine($"Tchau Tchau.");
            break;
    }
}

void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registro de Bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
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
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    ExibirTituloDaOpcao("Avaliar Banda");

    Console.Write("Digite o nome da banda que voce deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"Digite sua nota para a banda {nomeBanda}");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(notaBanda);
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada, digite qualque tecla para voltar ao menu principal.");
        Console.ReadKey();
    }

    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirMediaBanda()
{
    ExibirTituloDaOpcao("Exibir media da banda");

    Console.Write("Digite o nome da banda que voce deseja saber a nota: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
        Console.WriteLine($"A media das notas da banda {nomeBanda} é: {bandasRegistradas[nomeBanda].Average():f2}.");
    else
        Console.WriteLine($"Não foi possivel encontrar a banda {nomeBanda}.");

    Console.WriteLine($"Digite qualque tecla para voltar ao menu principal.");

    Console.ReadKey();
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteristico = string.Empty.PadLeft(quantidadeLetras, '*');

    Console.Clear();

    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico);
}

ExibirOpcoesDoMenu();
