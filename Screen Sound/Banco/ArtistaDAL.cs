using Microsoft.Data.SqlClient;
using Screen_Sound.Models;

namespace Screen_Sound.Banco;

internal class ArtistaDAL
{
    public IEnumerable<Banda> Listar()
    {
        List<Banda> lista = new();
        using var connection = new Connection().ObterConexao();
        connection.Open();

        using SqlCommand command = new("SELECT * FROM Artistas", connection);

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            string nomeArtista = reader["Nome"].ToString();
            string BioArtista = reader["Bio"].ToString();
            string fotoArtista = reader["FotoPerfil"].ToString();
            var banda = new Banda(nomeArtista)
            {
                Bio = BioArtista,
                FotoPerfil = fotoArtista,
            };
            lista.Add(banda);
        }
        return lista;
    }

    public void Inserir(Banda banda)
    {
        using var connection = new Connection().ObterConexao();
        connection.Open();

        using SqlCommand command = new("INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)", connection);
        command.Parameters.AddWithValue("@nome", banda.Nome);
        command.Parameters.AddWithValue("@perfilPadrao", banda.FotoPerfil);
        command.Parameters.AddWithValue("@bio", banda.Bio);

        int retorno = command.ExecuteNonQuery();
        Console.WriteLine($"Foram inseridos {retorno} registros na tabela Artistas.");
    }
}
