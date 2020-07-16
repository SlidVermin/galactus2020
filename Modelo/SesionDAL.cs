using Modelo.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.General.Instrucciones;

namespace Modelo
{
    public class SesionDAL
    {

        public static DataTable obtenerMenuUsuario(int idUsuario)
        {
            List<string> parametros = new List<string> { idUsuario.ToString() };
            return OperacionesBD.cargarResultadosSQL(SentenciasDAL.SEG_ARMAR_MENU, parametros);
        }

        public static DataTable obtenerOpcionesUsuario(int idUsuario)
        {
            List<string> parametros = new List<string> { idUsuario.ToString() };
            return OperacionesBD.cargarResultadosSQL(SentenciasDAL.SEG_LLENAR_PERMISOS, parametros);
        }        
    }
}
