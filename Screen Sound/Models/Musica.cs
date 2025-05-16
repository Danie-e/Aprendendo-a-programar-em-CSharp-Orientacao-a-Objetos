namespace Screen_Sound.Models
{
    public class Musica
    {
        public string Nome { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public int Duracao { get; set; }
        private bool Disponivel { get; set; }

        public void ExibirFicha()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine(Disponivel ? "A musica esta disponivel no plano" : "Musica não disponivel no plano.");
        }
    }
}
