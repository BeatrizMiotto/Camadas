using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;


namespace web.Controllers;

public class ProdutosController : Controller
{
    public IActionResult Index()
    {
        ViewBag.produtos = Produtos.Todos();
        return View();
    }

}
