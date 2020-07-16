using Entidad.HistoriaClinica.Resultado;
using Modelo.General;
using Modelo.General.Instrucciones;
using System;
using System.Collections.Generic;

namespace Modelo.HistoriaClinica.Resultado
{
    public class JustificacionAntibioticoDAL
    {
        public static void guardar(JustificacionAntibiotico justificacion)
        {
            try
            {

            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void cargarDatos(JustificacionAntibiotico justificacion)
        {
            try
            {
                List<string> lista = new List<string>();
                lista.Add(Convert.ToString(justificacion.idAtencion));
                lista.Add(Convert.ToString(justificacion.idJustificacion));
                lista.Add(Convert.ToString(justificacion.auditoria));
                justificacion.dsDatos = OperacionesBD.llenarDataset(SentenciasDAL.CARGAR_JUSTIFICACION_ANT, lista);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
