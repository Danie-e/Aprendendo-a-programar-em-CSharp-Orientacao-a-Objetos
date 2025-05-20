
using Screen_Sound.Models;

Banda Queen = new Banda("Queen");
Queen.AdicionarNota(new(10));

Musica musica1 = new Musica(Queen, "Love of my life")
{
    Duracao = 273,
    Disponivel = true,
};

Musica musica2 = new Musica(Queen, "Bohemian Rhapsody")
{
    Duracao = 275,
    Disponivel = false,
};

Album AlbumDoQueen = new Album("A Night at the Opera");
AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);

Queen.AdicionarAlbum(AlbumDoQueen);

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(Queen.Nome, Queen);

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
    Console.WriteLine("Digite 2 para registrar uma album.");
    Console.WriteLine("Digite 3 para exibir todas as bandas.");
    Console.WriteLine("Digite 4 para avaliar uma banda.");
    Console.WriteLine("Digite 5 para exibir media de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("Digite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarBanda();
            break;
        case 5:
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
    bandasRegistradas.Add(nomeDaBanda, new(nomeDaBanda));
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void RegistrarAlbum()
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
        bandasRegistradas[nomeBanda].AdicionarNota(new(notaBanda));
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
        Console.WriteLine($"A media das notas da banda {nomeBanda} é: {bandasRegistradas[nomeBanda].Media:f2}.");
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
