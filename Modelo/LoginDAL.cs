using Modelo.General;

using System.Collections.Generic;
using System.Data;
using Modelo.General.Instrucciones;


namespace Modelo
{
    public class LoginDAL
    {

        public static DataRow devolverDatosUsuario(string usuario, string clave)
        {
            List<string> listaParams = new List<string>();
            listaParams.Add(usuario);
            listaParams.Add(clave);

            return OperacionesBD.devuelveUnaFila(SentenciasDAL.SEG_AUTENTICACION, listaParams);
        }

    }
}
