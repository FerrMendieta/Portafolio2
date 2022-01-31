using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio2.Models;

namespace Portafolio2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public List<ProyectoDTO> ObtenerProyectos()
    {
        return new List<ProyectoDTO>()
        {
            new ProyectoDTO
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL= "/imagenes/Amazon.jpg"
            },
            new ProyectoDTO
            {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                Link= "https://nytimes",
                ImagenURL= "/imagenes/nyt.png"
            },
            new ProyectoDTO
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidad",
                ImagenURL = "/imagenes/Reddit.jpg",
                Link = "https://reddit.com"
            },
            new ProyectoDTO
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para videojuegos",
                Link= "https//store.steampower.com",
                ImagenURL= "/imagenes/Steam.png"
            }

    };
    }
    
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var Proyectos = ObtenerProyectos().Take(3).ToList();
        HomeIndexViewModel HIVM = new HomeIndexViewModel()
        {
            Proyectos = Proyectos
        };
        return View(HIVM);
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
