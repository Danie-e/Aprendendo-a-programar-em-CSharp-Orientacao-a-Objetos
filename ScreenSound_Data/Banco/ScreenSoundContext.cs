using Microsoft.EntityFrameworkCore;
using Screen_Sound.Models;

namespace Screen_Sound.Banco;

public class ScreenSoundContext : DbContext
{
    public DbSet<Banda> Bandas { get; set; }
    public DbSet<Album> Albuns { get; set; }
    private string StringConnection { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(StringConnection).UseLazyLoadingProxies();
    }
}
