namespace Negocio.Ingreso
{
    public class PacienteBL
    {
        /*public void establecerColumnas()
        {
            dtParametro.Columns.Add("idParametro", typeof(Int32));
        }
        public void cargarParametros()
        {
            SqlParameter sqlParam = new SqlParameter();
            List<SqlParameter> param = new List<SqlParameter>();
            sqlParam = new SqlParameter("@tblParametro", SqlDbType.Structured);
            sqlParam.Value = dtParametro;
            param.Add(sqlParam);
            GeneralDAL.llenarTablaParameter(Sentencias.PACIENTE_PARAMETROS_CARGAR, param, dtResultado);
        }
        public void cargarDatos()
        {
            List<string> paramas = new List<string>();
            paramas.Add(Convert.ToString(idPaciente));
            dtDatos = GeneralDAL.cargarResultadosSQL(Sentencias.PACIENTE_CARGAR, paramas);
            if (dtDatos.Rows.Count > 0)
            {
                tipoIdentificacion = Convert.ToString(dtDatos.Rows[0].Field<int>("IdTipoIdentificacion"));
                documentoIndentidad = dtDatos.Rows[0].Field<string>("documento");
                idEps = dtDatos.Rows[0].Field<int>("IdEps");
                idMunicipioExpedicion = Convert.ToString(dtDatos.Rows[0].Field<int>("IdMunicipioExpedicion"));
                idMunicipioNacimiento = Convert.ToString(dtDatos.Rows[0].Field<int>("IdMunicipioNacimiento"));
                idMunicipioResidencia = Convert.ToString(dtDatos.Rows[0].Field<int>("IdMunicipioResidencia"));
                idRegimen = Convert.ToString(dtDatos.Rows[0].Field<int>("idregimen"));
                idTipoAfiliacion = Convert.ToString(dtDatos.Rows[0].Field<int>("idtipoafiliacion"));
                idZonaUrbana = Convert.ToString(dtDatos.Rows[0].Field<int>("idzona"));
                idestrato = Convert.ToString(dtDatos.Rows[0].Field<int>("idestratosocial"));
                idEstadoCivil = Convert.ToString(dtDatos.Rows[0].Field<int>("idestadocivil"));
                primeroNombre = dtDatos.Rows[0].Field<string>("PrimerNombre");
                segundoNombre = dtDatos.Rows[0].Field<string>("SegundoNombre");
                primerApellido = dtDatos.Rows[0].Field<string>("primerapellido");
                segundoApellido = dtDatos.Rows[0].Field<string>("segundoapellido");
                idGenero = Convert.ToString(dtDatos.Rows[0].Field<int>("idgenero"));
                fechaNacimiento = dtDatos.Rows[0].Field<DateTime>("FechaNacimiento");

                direccionResidencia = dtDatos.Rows[0].Field<string>("Direccion");
                telefono = dtDatos.Rows[0].Field<string>("Telefono");
                celular = dtDatos.Rows[0].Field<string>("Celular");
                correo = dtDatos.Rows[0].Field<string>("Correo");

            }

        }

        public void eliminar()
        {
            PacienteDAL.eliminarPaciente(this);
        }
        public void cargarUbicaciones()
        {
            List<String> paramas = new List<string>();
            dtUbicacion = GeneralDAL.cargarResultadosSQL(Sentencias.UBICACION_GEOGRAFICA, paramas);
        }*/
    }
}
