using Modelo;
using Modelo.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginBL
    {

        public static void iniciarSesion()
        {

        }

        public static bool esAutenticacionValida(string usuario, string clave)
        {
            DataRow datosUsuario = LoginDAL.devolverDatosUsuario(usuario, clave);
            if (datosUsuario != null)
            {
                UsuarioActual.IdRol = (int)datosUsuario.ItemArray[0];
                UsuarioActual.IdUsuario = (int)datosUsuario.ItemArray[1];
                UsuarioActual.nombre = datosUsuario.Field<string>("Nombre");
                return true;
            }
            return false;
        }


    }
}
