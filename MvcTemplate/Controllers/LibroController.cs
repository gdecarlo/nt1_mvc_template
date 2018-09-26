using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTemplate.Models;

namespace MvcTemplate.Controllers
{
    public class LibroController : Controller
    {
        // GET: Libro
        public ActionResult Index()
        {
            List<Libro> libros = new List<Libro>();
            for (int i = 0; i < 5; i++)
            {
                int id = i + 1;
                libros.Add(new Libro(id, "Libro " + id, "8.5"));
            }
            return View(libros);

        }
    }
}