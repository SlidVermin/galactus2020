using System;
using System.Data;

namespace Entidad.Ingreso
{
    public class Admision
    {
        public int idAdmision { get; set; }
        public int idPaciente { get; set; }
        public DataTable dtPaciente = new DataTable();
        public string identificacion { get; set; }
        public string nombrePaciente { get; set; }
        public string regimen { get; set; }
        public string estratoSocial { get; set; }
        public string tipoAfiliacion { get; set; }
        public string nombreEPS { get; set; }
        public int idEps { get; set; }
        public int idEspecialidad { get; set; }
        public int idContrato { get; set; }
        public int idContacto { get; set; }
        public string idTriage { get; set; }
        public string identificacionAcompañante { get; set; }
        public string identificacionResponsable { get; set; }
        public string tipoDocumentoAcompañante { get; set; }
        public string tipoDocumentoResponsable { get; set; }
        public string nombreAcompañante { get; set; }
        public string nombreResponsable { get; set; }
        public string direccionAcompañante { get; set; }
        public string direccionResponsable { get; set; }
        public string idMunicipioAcompañante { get; set; }
        public string idMunicipioResponsable { get; set; }
        public string telefonoAcompañante { get; set; }
        public string telefonoResponsable { get; set; }
        public DateTime fecha { get; set; }
        public Boolean acompanante { get; set; }
        public Boolean responsable { get; set; }
        public DataSet dsDatos = new DataSet();
        public string cliente { get; set; }
        public string contacto { get; set; }
        public string especialidad { get; set; }
        public DataTable dtUbicacion = new DataTable();
        public DataTable dtParametro = new DataTable();
        public DataTable dtResultado = new DataTable();
     }
}
