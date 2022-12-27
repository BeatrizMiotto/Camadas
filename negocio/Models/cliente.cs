using MySql.Data.MySqlClient;

namespace Negocio.Models;

public class Cliente
{
    public int Id {get; set;}
    public string? Nome {get; set;}
    public string? Email {get; set;}

    private static readonly string conexao = "Server=localhost;Database=persistencia;Uid=root;Pwd=broot;";

    public void Salvar()
    {
        using(var connection = new MySqlConnection(conexao))
        {
            connection.Open();
            var query = $"insert into cliente(nome, email)values('{this.Nome}', '{this.Email}');";
            if(this.Id >0)
            {
                query = $"update cliente set nome ='{this.Nome}', email ='{this.Email}' where id ='{this.Id}';";
            }
            
            var command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    public static List<Cliente> BuscarPorIdOuEmail(string idOuEmail)
    {
        var clientes = new List<Cliente>();
        using(var connection = new MySqlConnection(conexao))
        {
            connection.Open();
            var query = $"select * from clientes where id = '{idOuEmail}' or email like '%{idOuEmail}%' ";
            var command = new MySqlCommand(query, connection);
            var dataReader = command.ExecuteReader();
            
            while(dataReader.Read())
            {
                clientes.Add(new Cliente{
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Nome = dataReader["nome"].ToString(),
                    Email = dataReader["email"].ToString()
                });

            }
            connection.Close();
        }
        return clientes;
    }

    public static List<Cliente> Todos()
    {
        var clientes = new List<Cliente>();
        using(var connection = new MySqlConnection(conexao))
        {
            connection.Open();
            var query = $"select * from clientes";
            var command = new MySqlCommand(query, connection);
            var dataReader = command.ExecuteReader();
            
            while(dataReader.Read())
            {
                clientes.Add(new Cliente{
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Nome = dataReader["nome"].ToString(),
                    Email = dataReader["email"].ToString()
                });

            }
            connection.Close();
        }
        return clientes;
    }
}