using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.HistoriaClinica
{
    public class HistoriaClinicaBL
    {
        /*public void listarEstancia()
        {

            try
            {
                dtEstancia = new DataTable();
                List<string> lista = new List<string>();
                lista.Add(Convert.ToString(auditoria));
                lista.Add(Convert.ToString(idAtencion));
                dtEstancia = GeneralUI.cargarResultadosSQL(Sentencias.CARGAR_ESTANCIA, lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void guardar()
        {
            preparar();
            EstanciaDAL.guardar(this);
        }
        private void preparar()
        {
            dtCambiosEstancia = dtEstancia.Copy();
            for (int i = 0; i < dtCambiosEstancia.Rows.Count; i++)
            {
                dtCambiosEstancia.Rows[i]["idUsuarioOrigen"] = (string.IsNullOrEmpty(dtCambiosEstancia.Rows[i]["idUsuarioOrigen"].ToString())) ?
                                                           SesionActualDAL.IdUsuario.ToString() :
                                                           dtCambiosEstancia.Rows[i]["idUsuarioOrigen"].ToString();
            }
            dtCambiosEstancia.AcceptChanges();
            dtCambiosEstancia.Columns.Remove("Código");
            dtCambiosEstancia.Columns.Remove("Asignar");
            dtCambiosEstancia.Columns.Remove("Descripción");
        }*/
    }
}
