using Microsoft.Data.SqlClient;
using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class Connection
{
    private string StringConnection { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(StringConnection);
    }

    public IEnumerable<Banda> Listar()
    {
        List<Banda> lista = new();
        using var connection = ObterConexao();
        connection.Open();

        using SqlCommand command = new("SELECT * FROM Artistas", connection);

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            string nomeArtista = reader["Nome"].ToString();
            var banda = new Banda(nomeArtista);
            lista.Add(banda);
        }
        return lista;
    }
}
