namespace Screen_Sound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }
    public int Nota { get; }

    public static Avaliacao Parse(string nota)
    {
        int notaAvaliacao = int.Parse(nota);
        return new Avaliacao(notaAvaliacao);
    }
}
