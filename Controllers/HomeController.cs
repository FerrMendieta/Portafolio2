using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio2.Models;
using Portafolio2.Servicios.Interfaces;

namespace Portafolio2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;

    public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
    {
        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
    }

    public IActionResult Index()
    {
        var Proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        HomeIndexViewModel HIVM = new()
        {
            Proyectos = Proyectos
        };
        return View(HIVM);
    }
    public IActionResult _Proyectos()
    {
        var proyectos = repositorioProyectos.ObtenerProyectos();
        return View(proyectos);
    }
    public IActionResult Contacto()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Contacto(ContactoViewModel ContactoViewModel)
    {
        return RedirectToAction("Gracias");
    }
    public IActionResult Gracias()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
