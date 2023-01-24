using Portafolio.Models;

namespace Portafolio.NET.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoViewModel> ObtenerProyectos();
    }

    public class RepositorioProyecto: IRepositorioProyectos
    {
        public List<ProyectoViewModel> ObtenerProyectos()
        {

            return new List<ProyectoViewModel>
            {
                new ProyectoViewModel {
                   Titulo = "Amazon",
                   Descripcion = "Donec ut mi non ante tempor.",
                   Link = "https://www.amazon.com/",
                   UrlImagen = "/images/Amazon.jpg",
                   FechaPublicacion = "3 de novimebre, 2022"
                },
                new ProyectoViewModel {
                   Titulo = "Facebook",
                   Descripcion = "Donec ut mi non ante tempor.",
                   Link = "https://www.facebook.com/",
                   UrlImagen = "/images/Facebook.jpg",
                   FechaPublicacion = "5 de novimebre, 2021"
                },
                new ProyectoViewModel {
                   Titulo = "Google",
                   Descripcion = "Donec ut mi non ante tempor.",
                   Link = "https://www.google.com/",
                   UrlImagen = "/images/Google.jpg",
                   FechaPublicacion = "19 de novimebre, 2021"
                },
                new ProyectoViewModel {
                   Titulo = "Linkedin",
                   Descripcion = "Donec ut mi non ante tempor.",
                   Link = "https://www.linkedin.com/",
                   UrlImagen = "/images/Linkedin.jpg",
                   FechaPublicacion = "7 de novimebre, 2022"
                }
            };
        }
    }
}
