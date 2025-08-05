using Microsoft.Data.SqlClient;

namespace Screen_Sound.Banco;

internal class Connection
{
    private string StringConnection { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(StringConnection);
    }
}
