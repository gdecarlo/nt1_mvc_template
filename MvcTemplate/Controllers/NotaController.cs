using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTemplate.Models;

namespace MvcTemplate.Controllers
{
    public class NotaController : Controller
    {
        // GET: Nota
        public ActionResult Index()
        {

            return View(GetNotas());
            //return View("NoSoyIndex"); //Cambiamos la convension de ASP.NET MVC
        }

        public ActionResult MasLejos()
        {
            return View("~/Views/Ejemplo/Index.cshtml"); //Cambiamos aun mas y accedemos a otra carpeta de vistas.
        }
        public ActionResult Create(Nota nota)
        {
            return View();
        }

        private List<Nota> GetNotas()
        {
            List<Nota> notas = new List<Nota>();
            for (int i = 0; i < 5; i++)
            {
                notas.Add(new Nota("Nota "+i));
            }
            return notas;
        }
    }
}