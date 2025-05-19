namespace Screen_Sound.Models
{
    public class Album
    {
        public string Nome { get; set; } = string.Empty;
        public int DuracaoTotal => MusicasAlbum.Sum(i => i.Duracao);
        private List<Musica> MusicasAlbum { get; set; } = new();
        public void AdicionarMusica(Musica musica)
        {
            MusicasAlbum.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Listas de musicas do album: {Nome}");
            foreach (Musica musica in MusicasAlbum)
            {
                Console.WriteLine($"Musica: {musica.Nome}");
            }
            Console.WriteLine($"Para ouir este album inteiro você precisa de {DuracaoTotal} segundos.");
        }
    }
}
