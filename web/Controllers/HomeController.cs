using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    

   
}
