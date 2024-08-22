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
}
