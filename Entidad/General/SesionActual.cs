using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidad.General
{

    public class UsuarioActual
    {
        private static int idRol;
        public static DataTable dtPermisos = new DataTable();
        public static DataTable dtMenu = new DataTable();
        public static SqlConnection conexion;

        public static SqlConnection getConexion()
        {
            return null;//return ConexionDB.obtenerConexion(0);
        }

        public static bool tienePermiso(int form, int opcion)
        {
            if (dtPermisos.Select("idmenu='" + form.ToString() + 
                "' and idpermiso = '" + opcion.ToString() + 
                "' and idrol ='" + idRol.ToString() + "'").Count() > 0)
            {
                return true;
            }
            return false;
        }
       
        public static int IdUsuario { get; set; }
        public static int IdRol { get; set; }

        public static string nombreUsuario { get; set; }
        public static string nombre { get; set; }
    }
}
