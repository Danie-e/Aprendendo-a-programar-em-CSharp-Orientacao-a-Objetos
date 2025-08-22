
using Screen_Sound.Banco;

namespace Screen_Sound.Models.Menus;

internal class RegistrarAlbum : Menu
{
    public override void Executar(DAL<Banda> bandaDAL)
    {
        ExibirTituloDaOpcao("Registrar album da banda");
        Console.Write("Digite o nome da banda que deseja cadastrar novo album: ");
        string nomeBanda = Console.ReadLine()!;
        Banda? banda = bandaDAL.ObterPor(banda => banda.Nome.Equals(nomeBanda));

        if (banda is not null)
        {
            Console.Write("Digite o nome do album: ");
            string nomeAlbum = Console.ReadLine()!;
            try
            {
                DAL<Album> albumDAL = new DAL<Album>(new ScreenSoundContext());

                albumDAL.Inserir(new Album(nomeAlbum, banda.Id));
                Console.WriteLine($"O album da banda {nomeBanda} foi registrado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi encontrada no sistema, cadastre a banda antes de cadastrar um album.");
            Thread.Sleep(2000);
            return;
        }
        Thread.Sleep(2000);
        Console.Clear();
    }
}
