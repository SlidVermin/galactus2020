using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.HistoriaClinica
{
    public class SolicitudLab
    {
        public int idSolicitud { get; set; }
        public int idAtencion { get; set; }
        public int idLaboratorio { get; set; }
        public DateTime fecha { get; set; }
        public DataTable dtLaboratorio { get; set; }

        public SolicitudLab() {
            dtLaboratorio = new DataTable();

            dtLaboratorio.Columns.Add("idOrdenMedica", Type.GetType("System.Int32"));
            dtLaboratorio.Columns.Add("idProcedimiento", Type.GetType("System.Int32"));
            dtLaboratorio.Columns.Add("Cups", Type.GetType("System.String"));
            dtLaboratorio.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtLaboratorio.Columns.Add("Enviado", Type.GetType("System.Boolean"));

        }
    }
}
