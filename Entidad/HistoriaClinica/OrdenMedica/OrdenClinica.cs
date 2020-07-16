using System;

namespace Entidad.HistoriaClinica.OrdenMedica
{
    public class OrdenClinica
    {
        public int idAtencion { get; set; }
        public bool auditoria { get; set; }
        public int idOrden { get; set; }
        public DateTime fechaOrden { get; set; }
        public OrdenClinicaIndicacion indicacion { get; set; }
        public OrdenClinicaMedicamento medicamento { get; set; }
        public OrdenClinicaOxigeno oxigeno { get; set; }
        public OrdenClinicaProcedimiento procedimiento { get; set; }
    }
        
}
