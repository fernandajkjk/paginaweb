using angarita2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace angarita2.Data
{
    public class ClienteData
    {
        public static bool registrarcliente(Cliente ocliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE ingresar_C'" +
            ocliente.documento + "','" + ocliente.nombre + "'," + ocliente.edad + ",'" +
             ocliente.apellido + "','" + ocliente.direccion + "','" + ocliente.correo + "','" +
            ocliente.telefono + "'";

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


        public static bool actualizarcliente(Cliente ocliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE actualizar_C '" +
            ocliente.documento + "','" + ocliente.nombre + "'," + ocliente.edad + ",'" +
             ocliente.apellido + "','" + ocliente.direccion + "','" + ocliente.correo + "','" +
            ocliente.telefono + "'";
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



        public static bool eliminarcliente(string documento)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE eliminar_C '" + documento + "'";
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







        public static List<Cliente> Obtener(string documento)
        {
            List<Cliente> oListaprofesor = new List<Cliente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE consultar_C'" + documento + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaprofesor.Add(new Cliente()
                    {
                        documento = Convert.ToInt32(dr["documento"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        edad = Convert.ToInt32(dr["edad"]),
                        direccion = dr["direccion"].ToString(),
                        correo = dr["Correo"].ToString(),
                        telefono = dr["Telefono"].ToString()
                    });
                }
                return oListaprofesor;
            }
            else
            {
                return oListaprofesor;
            }
        }
    }
}