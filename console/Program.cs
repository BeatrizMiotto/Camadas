using ConsoleApp.Models;

while(true)
{
    var cliente = new Cliente();
    Console.WriteLine("****Cadastro de Clientes****");
    Console.WriteLine("Nome:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("E-mail:");
    cliente.Email = Console.ReadLine();


    var produto = new Produtos();
    Console.WriteLine("****Cadastrar Produtos****");
    Console.WriteLine("Nome:");
    produto.Nome = Console.ReadLine();
    Console.WriteLine("Descrição:");
    produto.Descricao = Console.ReadLine();
    Console.WriteLine("Data de entrada do produto:");
    produto.DataCriacao = Console.ReadLine();
    Console.WriteLine("Data de validade do produto:");
    produto.DataValidade = Console.ReadLine();
    Console.WriteLine("Quantidade no estoque");
    produto.QuantidadeEstoque = Console.ReadLine();
}
