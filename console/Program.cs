using ConsoleApp.UIService;

while (true)
{
    Console.WriteLine("1- Cadastrar cliente");
    Console.WriteLine("2- Atualizar cliente");
    Console.WriteLine("3- Listar cliente");
    Console.WriteLine("4- Sair");

    var menu = Console.ReadLine();

    switch(menu)
    {
       case "1":
            ClientesUI.Cadastrar();
            break;
       case "2":
            break;
       case "3":
            break;
       case "4":
            break;
       default:
            break; 
    }
}
