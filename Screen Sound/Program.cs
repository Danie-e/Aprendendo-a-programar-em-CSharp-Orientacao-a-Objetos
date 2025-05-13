
List<string> listaDeBandas = new List<string> { "The Beatles", "U2", "Lady Gaga" };
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
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}.");
            break;
        case 4:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}.");
            break;
        default:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}.");
            Console.WriteLine($"Tchau Tchau.");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();

    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{

    Console.Clear();
    Console.WriteLine("*********************************************");
    Console.WriteLine("Exibindo nome de todas as bandas registradas.");
    Console.WriteLine("*********************************************\n");

    //for (int i = 0; i < listaDeBandas.Count; i++)
    //    Console.WriteLine($"Banda: {listaDeBandas[i]}");

    foreach (string banda in listaDeBandas)
        Console.WriteLine($"Banda: {banda}");


    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();

    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
