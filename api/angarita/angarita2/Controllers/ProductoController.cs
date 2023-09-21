using angarita2.Data;
using angarita2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace angarita2.Controllers
{
    public class ProductoController : ApiController
    {
        // GET api/<controller>
        public List<Producto> Get()
        {
            return ProductoData.Listar();
        }
        // GET api/<Controller>/
        public List<Producto> Get(string id)
        {
            return ProductoData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Producto oProducto)
        {
            return ProductoData.registrarproducto(oProducto);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Producto oProducto)
        {
            return ProductoData.actualizarproducto(oProducto);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ProductoData.eliminarproducto(id);
        }
    }
}