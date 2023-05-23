using Microsoft.AspNetCore.Mvc;

namespace TP4BISS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
         ViewBag.ListaPaises = Info.ListarPaises();
        return View("index");
    }
    public IActionResult DetallePais(string Pais)
    {
        ViewBag.PaisBuscado = Info.DetallePais(Pais);

        return View("detallepais");
    }
}
