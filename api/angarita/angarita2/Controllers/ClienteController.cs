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
    // GET api/<controller>/5
    public class ClienteController : ApiController
    {
        public List<Cliente> Get(string id)
        {
            return ClienteData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Cliente ocliente)
        {
            return ClienteData.registrarcliente(ocliente);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Cliente ocliente)
        {
            return ClienteData.actualizarcliente(ocliente);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ClienteData.eliminarcliente(id);
        }
    }
}