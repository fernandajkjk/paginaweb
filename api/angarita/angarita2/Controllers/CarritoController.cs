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
    public class CarritoController : ApiController
    {
        // GET api/<controller>
        // GET api/<controller>
        public List<Carrito> Get()
        {
            return CarritoData.Listar();
        }
        // GET api/<controller>/5
        public List<Carrito> Get(int id)
        {
            return CarritoData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Carrito oGrupo)
        {
            return CarritoData.registrarcarrito(oGrupo);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Carrito oGrupo)
        {
            return CarritoData.actualizarcarrito(oGrupo);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return CarritoData.eliminarcarrito(id);
        }
    }
}