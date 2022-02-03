using Portafolio2.Models;

namespace Portafolio2.Servicios.Interfaces
{
    public abstract class IRepositorioProyectos
    {
        public abstract List<ProyectoDTO> ObtenerProyectos();
    }
}
