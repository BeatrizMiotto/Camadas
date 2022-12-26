using MySql.Data.MySqlClient;

namespace ConsoleApp.Models;

public class Cliente
{
    public int Id {get; set;}
    public string? Nome {get; set;}
    public string? Email {get; set;}

    public void Salvar()
    {
        var conexao = "Server=localhost;Database=persistencia;Uid=root;Pwd=broot;";
        using(var connection = new MySqlConnection(conexao));
    }

}