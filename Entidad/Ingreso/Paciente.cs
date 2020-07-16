using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidad.Ingreso
{
    public class Paciente
    {
#region propiedades
        public int idPaciente { get; set; }
        public string tipoIdentificacion { get; set; }
        public string documentoIndentidad { get; set; }
        public string idMunicipioExpedicion { get; set; }
        public string idMunicipioNacimiento { get; set; }
        public string primeroNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string idGenero { get; set; }
        public string idestrato { get; set; }
        public string idEstadoCivil { get; set; }
        public string idMunicipioResidencia { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string correo { get; set;}
        public string idRegimen { get; set; }
        public string idZonaUrbana { get; set; }
        public string idTipoAfiliacion { get; set; }
        public int idUsuario { get; set;}
        public int idEps { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccionResidencia { get; set; }
        public int edad { get; set; }
        public DataTable dtDatos = new DataTable();
        public DataTable dtUbicacion = new DataTable();
        public DataTable dtParametro = new DataTable();
        public DataTable dtResultado = new DataTable();
        #endregion        
    }
}
