namespace Screen_Sound.Models;

public class Avaliacao
{
    public Avaliacao() { }
    public Avaliacao(int nota)
    {
        Nota = nota;
    }
    public int Id { get; set; }

    public int Nota { get; }

    public static Avaliacao Parse(string nota)
    {
        int notaAvaliacao = int.Parse(nota);
        return new Avaliacao(notaAvaliacao);
    }
}
