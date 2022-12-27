using Negocio.Models;

namespace ConsoleApp.UIService;

public class ClientesUI
{
    internal static void Cadastrar()
    {
        var cliente = new Cliente();
        Console.WriteLine("****Cadastro de Clientes****");
        Console.WriteLine("Nome:");
        cliente.Nome = Console.ReadLine();
        Console.WriteLine("E-mail:");
        cliente.Email = Console.ReadLine();

        cliente.Salvar();

        Console.Clear();
        MensagensUI.Mensagem("Cliente cadastrado!!!");
        Thread.Sleep(3000);
        Console.Clear();
    }
    internal static void Atualizar()
    {
        Console.WriteLine("****Atualizar Cliente****");
        Console.WriteLine("Digite o ID ou E-MAIl do cliente");
        
        var idOuEmail = Console.ReadLine();

        if(string.IsNullOrEmpty(idOuEmail))
        {
            MensagensUI.Mensagem("Digite o ID ou E-MAIL");
            ClientesUI.Atualizar();
            return;
              
        }
        var clientes = Cliente.BuscarPorIdOuEmail(idOuEmail);
        Console.WriteLine("Digite o Id do Cliente para atualizar");
        foreach(var cliente1 in clientes)
        {
            Console.WriteLine("Id: " + cliente1.Id);
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("E-mail: " + cliente1.Email);
            Console.WriteLine("========================");
        }
        if(clientes.Count == 0)
        {
            MensagensUI.Mensagem("Cliente não Localizado");
            ClientesUI.Atualizar();
            return;
        }
        var cliente = new Cliente();
        cliente.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o novo Nome: ");
        cliente.Nome = Console.ReadLine();

        Console.WriteLine("Digite o novo E-mail: ");
        cliente.Email = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Cliente Atualizado Com sucesso!!!");
        Thread.Sleep(3000);
        Console.Clear();
    }
    internal static void Listar()
    {
        Console.WriteLine("****Lista De Clientes****");
        var clientes = Cliente.Todos();
        foreach(var cliente in clientes)
        {
            Console.WriteLine("Id: " + cliente.Id);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("E-mail: " + cliente.Email);
            Console.WriteLine("========================");
        }

    }

}