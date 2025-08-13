using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class BandaDAl : DAL<Banda>
{
    public BandaDAl(ScreenSoundContext context) : base(context) { }
}
