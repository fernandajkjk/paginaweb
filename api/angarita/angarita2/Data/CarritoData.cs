using angarita2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace angarita2.Data
{
    public class CarritoData
    {
        public static bool registrarcarrito(Carrito oGrupo)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE ingresar_CA '" +
            oGrupo.documento + "','" + oGrupo.id_P + "'";


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



        public static bool actualizarcarrito(Carrito oGrupo)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE actualizar_CA '" +
            oGrupo.documento + "','" + oGrupo.id_P + "'";
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



        public static bool eliminarcarrito(string id_P)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE eliminar_grupo'" + id_P + "'";
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


        public static List<Carrito> Listar()
        {
            List<Carrito> oListagrupo = new List<Carrito>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE listar_grupo";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListagrupo.Add(new Carrito()
                    {

                        id_CA = Convert.ToInt32(dr["id_CA"]),
                        documento = Convert.ToInt32(dr["documento"]),
                        id_P = Convert.ToInt32(dr["id_P"]),
                        fechacompra = Convert.ToDateTime(dr["fechacompra"])

                    });
                }
                return oListagrupo;
            }
            else
            {
                return oListagrupo;
            }
        }


        public static List<Carrito> Obtener(int id_CA)
        {
            List<Carrito> oListaGrupo = new List<Carrito>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = " consultar_grupo '" + id_CA + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaGrupo.Add(new Carrito()
                    {
                        id_CA = Convert.ToInt32(dr["id_CA"]),
                        documento = Convert.ToInt32(dr["documento"]),
                        id_P = Convert.ToInt32(dr["id_P"]),
                        fechacompra = Convert.ToDateTime(dr["fechacompra"])
                    });
                }
                return oListaGrupo;
            }
            else
            {
                return oListaGrupo;
            }
        }
    }
}