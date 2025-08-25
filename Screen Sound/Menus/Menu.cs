using Screen_Sound.Banco;
using Screen_Sound.Models;

namespace Screen_Sound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteristico = string.Empty.PadLeft(quantidadeLetras, '*');

        Console.Clear();

        Console.WriteLine(asteristico);
        Console.WriteLine(titulo);
        Console.WriteLine(asteristico);
    }
    public virtual void Executar(DAL<Banda> bandasDAl)
    {
    }

}
