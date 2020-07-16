using System;
using System.Data;

namespace Entidad.HistoriaClinica.Evolucion
{
  public class EvolucionMedica
    {
        public int IdAtencion { get; set; }
        public DateTime fechaEvolucion { get; set; }
        public int idEvolucion { get; set; }
        public String Subjetivos { get; set; }
        public String PielFanera { get; set; }
        public String Generales { get; set; }
        public String SignosVitales { get; set; }
        public String CabezaCuello { get; set; }
        public String Torax { get; set; }
        public String CardioPulmonar { get; set; }
        public String Abdomen { get; set; }
        public String GenitalUrinario { get; set; }
        public String Extremidades { get; set; }
        public String SistemaNervioso { get; set; }
        public String Analisis { get; set; }
        public String Plan { get; set; }
        public DataTable dtDiagnostico = new DataTable();
        public DataTable dtAlistar = new DataTable();
        public DataSet dsDatos = new DataSet();

           }
}
