
using Screen_Sound.Banco;
using Screen_Sound.Models;
using Screen_Sound.Models.Menus;


try
{
    var artistaDal = new ArtistaDAL();
    artistaDal.Inserir(new Banda("Os Beatles")
    {
        FotoPerfil = "https://people.com/thmb/GEMT5hOHPAnXPDfA3Bh1U2NuDJE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(999x0:1001x2)/the-beetles-1-1a971bd703a849268568fcf20bee9fe1.jpg",
        Bio = "teste."
    });

    var listaArtistas = artistaDal.Listar();
  
    listaArtistas.Last().Bio = "Atualizar";
    artistaDal.Atualizar(listaArtistas.Last());

    listaArtistas = artistaDal.Listar();
   
    artistaDal.Deletar(listaArtistas.Last().Id);

    listaArtistas = artistaDal.Listar();
    foreach (var artista in listaArtistas)
        Console.WriteLine(artista.ToString());

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
return;

Banda Queen = new Banda("Queen");

Musica musica1 = new Musica(Queen, "Love of my life")
{
    Duracao = 273,
};

Musica musica2 = new Musica(Queen, "Bohemian Rhapsody")
{
    Duracao = 275,
    Disponivel = false,
};

Album AlbumDoQueen = new Album("A Night at the Opera");
Album AlbumMadeInHeaven = new Album("Made in Heaven");
AlbumMadeInHeaven.AdicionarNota(new(4));
AlbumMadeInHeaven.AdicionarNota(new(6));

AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);

Queen.AdicionarAlbum(AlbumDoQueen);
Queen.AdicionarAlbum(AlbumMadeInHeaven);

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(Queen.Nome, Queen);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new RegistrarBanda());
opcoes.Add(2, new RegistrarAlbum());
opcoes.Add(3, new MostrarBandasRegistradas());
opcoes.Add(4, new AvaliarBanda());
opcoes.Add(5, new AvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());
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
    Console.WriteLine("Digite 5 para avaliar um album.");
    Console.WriteLine("Digite 6 para exibir media de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("Digite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    opcoes[opcaoEscolhida].Executar(bandasRegistradas);
    if (opcaoEscolhida > 0)
        ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
