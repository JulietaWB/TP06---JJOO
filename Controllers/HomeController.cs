using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp06_JJOO_visual.Models;

namespace Tp06_JJOO_visual.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Deportes()
    {
        return View();
    }
    
    public IActionResult Paises()
    {
        return View();
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        return View(DetalleDeporte);
    }

    public IActionResult VerDetallePais(int idPais)
    {
       return View(DetallePais); 
    }

    public IActionResult VerDetalleDeportista(int idDeportista)
    {
        return View(DetalleDeportista);
    }

    public IActionResult AgregarDeportista()
    {
        return View();
    }

    [HttpPost] IActionResult GuardarDeportista(Deportista dep)
    {

    }
    IActionResult EliminarDeportista(int idCandidato)
    {

    }
    IActionResult Creditos()
    {

    }
}
