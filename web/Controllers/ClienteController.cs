using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;
using Negocio.Models;

namespace web.Controllers;

public class ClienteController : Controller
{
    public IActionResult Index()
    {
        ViewBag.cliente = Cliente.Todos();
        return View();
    }
     public IActionResult Cadastrar([FromForm] Cliente cliente)
    {
        if(string.IsNullOrEmpty(cliente.Nome))
        {
            ViewBag.erro = "O nome do cliente não pode ser vazio";
            return View();
        }
        cliente.Salvar();
        return Redirect("/cliente");
    }
    [Route("/cliente/{id}/editar")]
    public IActionResult Editar([FromRoute] int id)
    {
        ViewBag.cliente = Cliente.BuscaPorId(id);
        return View();
    }
    
    [Route("/cliente/{id}/atualizar")] 
    public IActionResult Atualizar([FromRoute] int id, [FromForm] Cliente cliente)
    {
        cliente.Id = id;
        cliente.Salvar();
        return Redirect("/cliente");
    } 
    [Route("/cliente/{id}/excluir")]
    public IActionResult Excluir([FromRoute] int id)
    {
        
        Cliente.ExcluirPorId(id);
        return Redirect("/cliente");
    }
}
