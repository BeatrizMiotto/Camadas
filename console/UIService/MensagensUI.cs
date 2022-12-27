using Negocio.Models;

namespace ConsoleApp.UIService;

internal class MensagensUI
{
    public static void Mensagem(string mensagem, int timer = 3000)
    {
        Console.Clear();
        Console.WriteLine(mensagem);
        Thread.Sleep(timer);
        Console.Clear();
    }
}