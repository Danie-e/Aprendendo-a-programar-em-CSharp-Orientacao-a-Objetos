﻿
using Screen_Sound.Filters;
using Screen_Sound.Models;
using Screen_Sound.Models.Menus;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //foreach (Musica musica in musicas)
        //    musica.ExibirDetalhesMusica();

        //LinqFilter.FiltrarGenerosMusicais(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");

        MusicasPreferidas musicasDaDani = new("Daniela");
        musicasDaDani.AdicionarMusicaFavorita(musicas[1]);
        musicasDaDani.AdicionarMusicaFavorita(musicas[2]);
        musicasDaDani.AdicionarMusicaFavorita(musicas[3]);
        musicasDaDani.AdicionarMusicaFavorita(musicas[4]);
        musicasDaDani.AdicionarMusicaFavorita(musicas[5]);
        //musicasDaDani.EscrevaMusicasFavoritas();
        musicasDaDani.GerarArquivoJson();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Banda Queen = new Banda("Queen");
Queen.AdicionarNota(new(10));

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
