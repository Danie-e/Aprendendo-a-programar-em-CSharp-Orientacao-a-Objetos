namespace Screen_Sound.Models
{
    class Banda
    {
        public List<Album> ListaDeAlbuns { get; set; } = new();
        public string Nome { get; set; }
        public void AdicionarAlbum(Album album)
        {
            ListaDeAlbuns.Add(album);
        }                            
        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in ListaDeAlbuns)
            {
                Console.WriteLine($"O album {album.Nome} possue duração: {album.DuracaoTotal} segundos.");
            }
        }
    }
}
