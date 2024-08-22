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
        ViewBag.ListaDeportes= BD.ListarDeportes();
        return View();
    }
    
    public IActionResult Paises()
    {
        ViewBag.ListaPaises= BD.ListarPaises();
        return View();
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        ViewBag.Dep= BD.VerInfoDeporte(idDeporte);
        ViewBag.ListaDepor= BD.ListarDeportistasxDeporte(idDeporte);
        return View();
    }

    public IActionResult VerDetallePais(int idPais)
    {
        ViewBag.InfoPais = BD.VerInfoPais(idPais);
        ViewBag.ListaDeportistas= BD.ListarDeportistasxPais(idPais);
       return View("DetallePais"); 
    }

    public IActionResult VerDetalleDeportista(int idDeportista)
    {
        ViewBag.DatosDeportista = BD.VerInfoDeportista(idDeportista);
        return View("DetalleDeportista");
    }

    public IActionResult AgregarDeportista()
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View("FormularioDeportistas");
    }

    [HttpPost] IActionResult GuardarDeportista(Deportista dep)
    {
        BD.AgregarDeportistas(dep);
        return View("Index");
    }
    IActionResult EliminarDeportista(int idCandidato)
    {
        BD.EliminarDeportista(idCandidato);
        return View("Index");
    }
    IActionResult Creditos()
    {
        return View();
    }
}
