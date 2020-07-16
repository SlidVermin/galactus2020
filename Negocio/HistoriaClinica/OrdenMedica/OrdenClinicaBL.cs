using System;
using Entidad.HistoriaClinica.OrdenMedica;

namespace Negocio.HistoriaClinica.OrdenMedica
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
        public OrdenClinica()
        {
            indicacion = new OrdenClinicaIndicacion();
            medicamento = new OrdenClinicaMedicamento();
            oxigeno = new OrdenClinicaOxigeno();
            procedimiento = new OrdenClinicaProcedimiento();
        }
        public void nuevaOrden()
        {
            /*idOrden = ConsultasHistoriaClinica.NUEVO;
            indicacion.indicacion = string.Empty;
            medicamento.tblMedicamentos.Clear();
            medicamento.tblInfusionImpregnacion.Clear();
            medicamento.tblMezcla.Clear();
            procedimiento.tblProcedimientos.Clear();
            agregarFila();*/
        }
        public void agregarFila() {
            medicamento.tblMedicamentos.Rows.Add();
            medicamento.tblInfusionImpregnacion.Rows.Add();
            procedimiento.tblProcedimientos.Rows.Add();
            /*if (oxigeno.tblOxigeno.Rows.Count == 1) {
                oxigeno.tblOxigeno.Rows.Add();
            } else if (oxigeno.tblOxigeno.Rows.Count == 0) {
                oxigeno.tblOxigeno.Rows.Add();
                oxigeno.tblOxigeno.Rows.Add();
            }*/
        }
    }
}
