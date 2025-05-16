namespace Screen_Sound.Models
{
    public class Album
    {
        public string Nome { get; set; }
        public int DuracaoTotal { get; set; }
        private List<Musica> MusicasAlbum { get; set; }
        public void AdicionarMusica(Musica musica)
        {
            MusicasAlbum.Add(musica);
        }
    }
}
