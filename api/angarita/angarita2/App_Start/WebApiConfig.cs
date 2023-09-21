using angarita2.Data;
using angarita2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
namespace angarita2
{
    public static class WebApiConfig
    {

        public static bool registrarproducto(Producto oproducto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE ingresar_P '" +
            oproducto.id_P + "','" + oproducto.nombre_P + "','" +
             oproducto.descrip + "','" + oproducto.imagen + "','" + oproducto.precio + "'";


            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }


        public static bool actualizarproducto(Producto oproducto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE actualizar_P '" +
                       oproducto.id_P + "','" + oproducto.nombre_P + "','" +
             oproducto.descrip + "','" + oproducto.imagen + "','" + oproducto.precio + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }



        public static bool eliminarproducto(string id_P)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE eliminar_P '" + id_P + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }



        public static List<Producto> Listar()
        {
            List<Producto> oListaestudiante = new List<Producto>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE listar_P ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaestudiante.Add(new Producto()
                    {
                        id_P = Convert.ToInt32(dr["id_P"]),
                        nombre_P = dr["nombre_P"].ToString(),
                        descrip = dr["descrip"].ToString(),
                        imagen = dr["imagen"].ToString(),
                        precio = Convert.ToInt32(dr["precio"])



                    });
                };
                dr.Close();
                return oListaestudiante;
            }
            else
            {
                return oListaestudiante;
            }
        }

        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
