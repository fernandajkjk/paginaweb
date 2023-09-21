using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angarita2.Models
{
    public class Cliente
    {
        public int documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
    }
}