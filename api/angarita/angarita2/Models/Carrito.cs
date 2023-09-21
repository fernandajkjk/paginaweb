using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angarita2.Models
{
    public class Carrito
    {
        public int id_CA { get; set; }
        public int documento { get; set; }
        public int id_P { get; set; }
        public DateTime fechacompra { get; set; }
    }
}