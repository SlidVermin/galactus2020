using System;
using System.Data.SqlClient;


namespace Modelo.General
{
    public class Funciones
    {
        internal static string obtenerFechaServidor(int frmto)
        {
            string fcha;
            if (validarFormatoFecha(frmto))
            {
                fcha = ejecutarConsultaSQL("SELECT CONVERT(varchar,GETDATE()," + frmto.ToString() + ") AS Fecha", "Fecha");
                return fcha;
            }
            else
                return "0";
        }

        private static bool validarFormatoFecha(int formato)
        {
            if ((formato >= 0 && formato < 15) | (formato > 99 && formato < 115))
                return true;
            else
                return false;
        }

        public static string ejecutarConsultaSQL(string consultaSQL, string item)
        {
            string valor = String.Empty;
            try
            {
                using (var consulta = new SqlCommand(consultaSQL, SesionActualDAL.getConexion()))
                {
                    using (var resultado = consulta.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            resultado.Read();
                            valor = resultado[item].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public static bool fechaValida(string fecha) {
            try
            {
                DateTime fechaEsperada;
                fechaEsperada = DateTime.Parse(fecha);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
        


    }
}
