using Microsoft.AspNetCore.Mvc;
using holamundo.Models;
namespace holamundo.Controllers;


public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.año = 2005;
        escuela.escuelaId = Guid.NewGuid().ToString();
        escuela.nombre = "mi casa";
        return View(escuela);
    }
}