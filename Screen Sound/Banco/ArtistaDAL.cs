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
            int id = int.Parse(reader["Id"].ToString());
            var banda = new Banda(nomeArtista)
            {
                Bio = BioArtista,
                FotoPerfil = fotoArtista,
                Id = id
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
    public void Atualizar(Banda banda)
    {
        using var connection = new Connection().ObterConexao();
        connection.Open();
        Console.WriteLine(banda.ToString());
        using SqlCommand command = new("UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id", connection);
        command.Parameters.AddWithValue("@nome", banda.Nome);
        command.Parameters.AddWithValue("@bio", banda.Bio);
        command.Parameters.AddWithValue("@id", banda.Id);

        int retorno = command.ExecuteNonQuery();
        Console.WriteLine($"Foram atualizados {retorno} registros na tabela Artistas.");
    }
    public void Deletar(int id)
    {
        using var connection = new Connection().ObterConexao();
        connection.Open();
        Console.WriteLine(id);

        using SqlCommand command = new("DELETE FROM Artistas WHERE Id = @id", connection);
        command.Parameters.AddWithValue("@id", id);

        int retorno = command.ExecuteNonQuery();
        Console.WriteLine($"Foram deletados {retorno} registros na tabela Artistas.");
    }
}
