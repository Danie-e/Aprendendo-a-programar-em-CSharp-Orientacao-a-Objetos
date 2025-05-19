namespace Screen_Sound.Models
{
    public class Musica
    {
        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }
        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida { get { return $"A musica {Nome} e do artista {Artista.Nome}"; } }

        public void ExibirFicha()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine(Disponivel ? "A musica esta disponivel no plano" : "Musica não disponivel no plano.");
        }

        public void EscreveDisponivel(bool value)
        {
            Disponivel = value;
        }

        public bool LeDisponivel()
        {
            return Disponivel;
        }
    }
}
