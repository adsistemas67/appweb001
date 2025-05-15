using appweb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace appweb001.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }



        public IActionResult Crear(Contactos contacto)
        {
            
            var contexto= new ContextoDeDatos();

            contexto.contactos.Add(contacto);



            return View();
        }


    }
}
