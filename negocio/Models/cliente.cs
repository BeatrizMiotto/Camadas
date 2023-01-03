using MySql.Data.MySqlClient;

namespace Negocio.Models;

public class Cliente
{
    public int Id {get; set;}
    public string? Nome {get; set;}
    public string? Email {get; set;}

    private static readonly string conexao = "Server=localhost;Database=estoque;Uid=root;Pwd=broot;";

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
            var query = $"select * from cliente where id = '{idOuEmail}' or email like '%{idOuEmail}%' ";
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
            var query = $"select * from cliente";
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

    public static Cliente? BuscaPorId(int id)
    {
        var cliente = new Cliente();
        using(var connection = new MySqlConnection(conexao))
        {
            connection.Open();
            var query = $"select * from cliente where id = '{id}' ";
            var command = new MySqlCommand(query, connection);
            var dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                cliente = new Cliente{
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Nome = dataReader["nome"].ToString(),
                    Email = dataReader["email"].ToString()
                };
            }
            connection.Close();
        }
        return cliente.Id == 0 ? null : cliente;
    }
    public static void ExcluirPorId(int id)
    {
       using(var connection = new MySqlConnection (conexao))
        {
            connection.Open();
            var query = $"delete from cliente where id ='{id}';";
    
            var command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
        
}
