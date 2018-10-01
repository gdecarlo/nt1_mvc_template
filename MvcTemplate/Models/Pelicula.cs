using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTemplate.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Display(Name = "Puntuación")]
        public string Rating { get; set; }

        public Pelicula(int id, string nombre, string rating)
        {
            Id = id;
            Nombre = nombre;
            Rating = rating;
        }
    }
}