using ConsoleApp.Models;

while(true)
{
    var cliente = new Cliente();
    Console.WriteLine("****Cadastro de Clientes****");
    Console.WriteLine("Nome:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("E-mail:");
    cliente.Email = Console.ReadLine();
}
