using MySql.Data.MySqlClient;

namespace Negocio.Models;

public class Cliente
{
    public int Id {get; set;}
    public string? Nome {get; set;}
    public string? Email {get; set;}

    public void Salvar()
    {
        var conexao = "Server=localhost;Database=persistencia;Uid=root;Pwd=broot;";
        using(var connection = new MySqlConnection(conexao))
        {
            connection.Open();
            var query = $"insert into cliente(nome, email)values('{this.Nome}', '{this.Email}');";
            var command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

}