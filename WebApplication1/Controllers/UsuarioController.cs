using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Buscar(string nombre)
        {
            var input = "<h1>" + nombre + "</h1>";
            return Content(input);
        }
    }
}