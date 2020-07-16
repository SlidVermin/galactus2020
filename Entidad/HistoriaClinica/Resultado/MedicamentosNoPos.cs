using System;
using System.Data;



namespace Entidad.HistoriaClinica.Resultado
{
    public class MedicamentosNoPos
    {
        public DataSet dsDatos = new DataSet();
        public int idAtencion { set; get; }
        public int idSolicitud { set; get; }
        public int idOrdenMedica { set; get; }
        public DateTime fechaSolicitud { set; get; }
        public int diasTratamiento { set; get; }
        public string dosis { set; get; }
        public string frecuencia { set; get; }
        public string dosisSolicitada { set; get; }
        public string resumenHC { set; get; }
        public Boolean otroPosUtilizado { set; get; }
        public Boolean posibilidadTerapeutica { set; get; }
        public string respuestaPos { set; get; }
        public string efectoDeseado { set; get; }
        public string indicacionEfecto { set; get; }
        public string explicacionRazon { set; get; }
        public Boolean criterio1 { set; get; }
        public Boolean criterio2 { set; get; }
        public string precaucionesOtros { set; get; }
        public string peligro { set; get; }
        public string reaccionesSecundaria { set; get; }
        public string contraIndicaciones { set; get; }
        public DateTime fechaCTC { set; get; }
        public string encabezadoCTC { set; get; }
        public string decisionCTC { set; get; }
        public Boolean auditoria { set; get; }
        public int idMedicamentoActual { set; get; }
        public int idMedicamentoReemplazar { set; get; }
        public string paciente { set; get; }
        public string documento { set; get; }
        public string edad { set; get; }
        public string estancia { set; get; }
        public string estado { set; get; }
        public string cama { set; get; }
        public string causaExterna { set; get; }
        public string institucion { set; get; }
        public DateTime fechaIngreso { set; get; }
        public string area { set; get; }
        public string entorno { set; get; }
        public DataTable dtDiagnostico = new DataTable();
        public string nombreMedicamentoActual { set; get; }
        public string nombreMedicamentoNuevo { set; get; }
        public string motivoIngreso { set; get; }
    }
        
}
