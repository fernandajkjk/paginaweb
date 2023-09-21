using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angarita2.Models
{
    public class Producto
    {
        public int id_P { get; set; }
        public string nombre_P { get; set; }
        public string descrip { get; set; }
        public string imagen { get; set; }
        public int precio { get; set; }
    }
}