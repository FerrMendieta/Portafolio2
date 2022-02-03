using Portafolio2.Models;
using Portafolio2.Servicios.Interfaces;

namespace Portafolio2.Servicios
{
    public class RepositorioProyectos:IRepositorioProyectos
    {
        public override List<ProyectoDTO> ObtenerProyectos()
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

    }
}
