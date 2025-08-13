using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class AlbumDAL : DAL<Album>
{
    public AlbumDAL(ScreenSoundContext context) : base(context) { }
}
