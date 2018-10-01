using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Saludar()
        {

            return View("NoSoySaludar"); //Cambiamos la convension de ASP.NET MVC
        }

        public ActionResult MuyLejos()
        {
            return View("~/Views/Ejemplo/Index.cshtml"); //Cambiamos aun mas y accedemos a otra carpeta de vistas.
        }

    }
}