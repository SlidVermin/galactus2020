using Modelo;
using Modelo.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SesionBL 
    {
        public static void iniciarSesion(int idUsuario)
        {
            UsuarioActual.dtMenu = SesionDAL.obtenerMenuUsuario(idUsuario);
            UsuarioActual.dtPermisos = SesionDAL.obtenerOpcionesUsuario(idUsuario);
        }
    }
}
