using System;
using System.Data;

namespace Entidad.HistoriaClinica.OrdenMedica
{
    public class OrdenClinicaMedicamento
    {
        public DataTable tblMedicamentos { get; set; }

        public DataTable tblInfusionImpregnacion { get; set; }
        public DataTable tblMezcla;

        public DataTable dtCambiosMedicamento = new DataTable();
        public DataTable dtCambiosInfusionImpregnacion = new DataTable();
        public DataTable dtCambiosMezcla = new DataTable();
        public DataTable dtCambiosProcedimiento = new DataTable();
        private int consecutivoActual;

    }        
}
