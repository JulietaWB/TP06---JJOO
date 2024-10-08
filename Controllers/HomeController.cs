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
        ViewBag.ListaDepor= BD.ListarDeportistasxPais(idPais);
       return View(); 
    }

    public IActionResult VerDetalleDeportista(int idDeportista)
    {
        ViewBag.DatosDepor = BD.VerInfoDeportista(idDeportista);
        return View();
    }

    public IActionResult AgregarDeportista()
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View();
    }


   /* [HttpPost] IActionResult GuardarDeportista(string Nombre, string Apellido, string Foto, int IdPais, int IdDeporte)
    {
        if (Nombre is null || Apellido is null || Foto is null || IdPais is null || IdDeporte is null)
        {
            ViewBag.ListaPaises = BD.ListarPaises();
            ViewBag.ListaDeportes = BD.ListarDeportes();
            ViewBag.MsjError= "No pueden haber campos vacíos.";
            return View("AgregarDeportista");

        } else
        {

            ViewBag.MsjError= "No pueden haber campos vacíos.";
            ViewBag.listaDestinos = ORTWorld.CargarDestinos();
            ViewBag.listaHoteles =  ORTWorld.CargarHoteles();
            ViewBag.listAereos = ORTWorld.CargarAereos();
            ViewBag.listExcursiones = ORTWorld.CargarExcursiones();
            return View ("SelectPaquetes");
            return View("Index");
        }



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
    */

}
