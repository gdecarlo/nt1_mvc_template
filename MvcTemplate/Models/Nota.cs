using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTemplate.Models
{
    public class Nota
    {

        public int id { get; set; }
        public string texto { get; set; }
        public bool esImportante { get; set; }

        public Nota()
        {
            
        }

        public Nota(string texto)
        {
            this.texto = texto;
        }
    }
}