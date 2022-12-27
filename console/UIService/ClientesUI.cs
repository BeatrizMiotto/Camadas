using Negocio.Models;

namespace ConsoleApp.UIService;

public class ClientesUI
{
    public static void Cadastrar()
    {
        var cliente = new Cliente();
        Console.WriteLine("****Cadastro de Clientes****");
        Console.WriteLine("Nome:");
        cliente.Nome = Console.ReadLine();
        Console.WriteLine("E-mail:");
        cliente.Email = Console.ReadLine();

        cliente.Salvar();

        Console.Clear();
        Console.WriteLine("Cliente cadastrado!!!");
        Thread.Sleep(3000);
        Console.Clear();
    }
}