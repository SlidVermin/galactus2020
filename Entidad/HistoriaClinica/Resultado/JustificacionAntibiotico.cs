using System;
using System.Data;
namespace Entidad.HistoriaClinica.Resultado
{
    public class JustificacionAntibiotico
    {
      public int idAtencion { get; set; }
      public int idOrdenMedica { get; set; }
        public Boolean auditoria { get; set; }
        public DataSet dsDatos = new DataSet();
        public int idJustificacion { get; set; }
        public string nombreMedicamentoActual { get; set; }
        public int idMedicamentoActual { get; set; }
        public string documentoIdentidad { get; set; }
        public string paciente { get; set; }
        public string cama { get; set; }
        public string estancia { get; set; }
        public string edad { get; set; }
        public string area { get; set; }
        public string entorno { get; set; }
        public string viaIngreso { get; set; }
        public string causaExterna { get; set; }
            }
}
