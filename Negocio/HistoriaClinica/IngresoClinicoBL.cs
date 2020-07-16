using System;
using System.Collections.Generic;
using System.Data;
using Modelo.HistoriaClinica;
using Modelo.HistoriaClinica;
using Modelo.General.Instrucciones;
using Modelo.General;
using Modelo.General;
using Entidad.HistoriaClinica;

namespace Negocio.HistoriaClinica
{
   public class IngresoClinicoBL
    {
        public int IdAtencion { get; set; }
        public String Peso { get; set; }
        public String MotivoIngreso { get; set; }
        public String AntecedentesMedicos { get; set; }
        public String AntecedentesQuirurgicos { get; set; }
        public String AntecedentesTransfusionales { get; set; }
        public String AntecedentesAlergicos { get; set; }
        public String AntecedentesTraumaticos { get; set; }
        public String AntecedentesToxicos { get; set; }
        public String AntecedentesFamiliares { get; set; }
        public String RevisionSistema { get; set; }
        public String Generales { get; set; }
        public String SignosVitales { get; set; }
        public String CabezaCuello { get; set; }
        public String Torax { get; set; }
        public String CardioPulmonar { get; set; }
        public String Abdomen { get; set; }
        public String GenitalUrinario { get; set; }
        public String Extremidades { get; set; }
        public String SistemaNervioso { get; set; }
        public String Paraclinicos { get; set; }
        public String Analisis { get; set; }
        public String Pronostico { get; set; }
        public int IdUsuario { get; set; }
        public String resumenClinico { get; set;}
        public String pielFaneras { get; set; }
        public DateTime FechaOrigen { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public DataTable dtDiagnostico = new DataTable();
        public DataTable dtDatos = new DataTable();
        public DataTable dtDatosAtencion = new DataTable();
        public String numeroAutorizacion { get; set; }
        public String cama { get; set; }
        public String institucion { get; set; }
        public String causaExterna { get; set; }
        public String viaIngreso { get; set; }
        public DataTable dtImpresion = new DataTable();

        public DataTable dtAlistar = new DataTable();
        public String edadMadre { get; set; }
        public String edadGestional { get; set; }
        public String fum { get; set; }
        public String obstreticos { get; set; }
        public String hemoclasificacionMadre { get; set; }
        public String hemoclasificacionPadre { get; set; }
        public String vacunacion { get; set; }
        public String preeclampcia { get; set; }
        public String controlPrenatal { get; set; }
        public String medicamentoDuranteEmbarazo { get; set; }
        public String hipertensionGestacional { get; set; }
        public String habitos { get; set; }
        public String infeccionEmbarazo { get; set; }
        public String enfermedadTiroidea { get; set; }
        public String diabeteMellitius { get; set; }
        public String diabeteGestacional { get; set; }
        public string tipoParto { get; set; }
        public string inducionParto { get; set; }
        public string apgar1 { get; set; }
        public string apgar5 { get; set; }
        public string reanimacionNacer { get; set; }
        public string rupturasMemb { get; set; }
        public string caractLiquidas { get; set; }
        public string hemoclasificacion { get; set; }
        public string tsh { get; set; }
        public string vdrl { get; set; }
        public string glucometrias { get; set; }
        public int genero { get; set; }
        public String torch { get; set; }
        public DataTable dtMaterno = new DataTable();
        public DataTable dtNacimiento = new DataTable();
        public DataTable dtRecienNacido = new DataTable();
        public DataSet dsDatos = new DataSet();
        public void cargarDiagnostico(IngresoClinico ingresoClinico)
        {
            IngresoClinicoDAL.cargarDiagnostico(ingresoClinico);
        }

        public void establecerDt()
        {
            dtImpresion.Columns.Add("Id", typeof(String));
            dtImpresion.Columns.Add("Código", typeof(String));
            dtImpresion.Columns.Add("Descripcion", typeof(String));
          
        }
        public void establecerDtNacimiento()
        {
            dtNacimiento.Reset();
            dtNacimiento.Columns.Add("idAtencion", typeof(int));
            dtNacimiento.Columns.Add("TipoParto", typeof(String));
            dtNacimiento.Columns.Add("InducionParto", typeof(String));
            dtNacimiento.Columns.Add("Apgar1", typeof(String));
            dtNacimiento.Columns.Add("Nacer", typeof(String));
            dtNacimiento.Columns.Add("RupturasMemb", typeof(String));
            dtNacimiento.Columns.Add("CaractLiquidas", typeof(String));
            dtNacimiento.Columns.Add("Apgar5", typeof(String));
        }
        public void establecerDtRecienNacido()
        {
            dtRecienNacido.Reset();
            dtRecienNacido.Columns.Add("idAtencion", typeof(int));
            dtRecienNacido.Columns.Add("Hemoclasificacion", typeof(String));
            dtRecienNacido.Columns.Add("Tsh", typeof(String));
            dtRecienNacido.Columns.Add("VDRL", typeof(String));
            dtRecienNacido.Columns.Add("Glucometrias", typeof(String));
        }
        public void establecerDtMaterno()
        {
            dtMaterno.Reset();
            dtMaterno.Columns.Add("idAtencion", typeof(int));
            dtMaterno.Columns.Add("EdadMadre", typeof(String));
            dtMaterno.Columns.Add("EdadGestacional", typeof(String));
            dtMaterno.Columns.Add("Preclampsia", typeof(String));
            dtMaterno.Columns.Add("Fum", typeof(String));
            dtMaterno.Columns.Add("obstetricos", typeof(String));
            dtMaterno.Columns.Add("hemoclasificacionMadre", typeof(String));
            dtMaterno.Columns.Add("hemoclasificacionPadre", typeof(String));
            dtMaterno.Columns.Add("vacunacion", typeof(String));
            dtMaterno.Columns.Add("controlPrenatal", typeof(String));
            dtMaterno.Columns.Add("medicamentoDuranteEmbarazo", typeof(String));
            dtMaterno.Columns.Add("hipertensionGestacional", typeof(String));
            dtMaterno.Columns.Add("habitos", typeof(String));
            dtMaterno.Columns.Add("infeccionDuranteEmbarazo", typeof(String));
            dtMaterno.Columns.Add("enfermedadTiroidea", typeof(String));
            dtMaterno.Columns.Add("diabeteGestacional", typeof(String));
            dtMaterno.Columns.Add("diabeteMellitus", typeof(String));
            dtMaterno.Columns.Add("torch", typeof(String));
        }

        public void generoPestañas()
        {
            DataTable dt = new DataTable();
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(IdAtencion));
            dt = OperacionesBD.cargarResultadosSQL(SentenciasDAL.GENERO_VERIFICAR_INGRESO, lista);
            if (dt.Rows.Count > 0)
            {
                genero = (int) dt.Rows[0]["idGenero"];
            }
        }
        public void cargarDatosAtencion()
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(IdAtencion));
            dtDatosAtencion = OperacionesBD.cargarResultadosSQL(SentenciasDAL.CARGAR_DATOS_ATENCION, list);
            if (dtDatosAtencion.Rows.Count > 0)
            {
                numeroAutorizacion = dtDatosAtencion.Rows[0].Field<String>("numAutorizacion");
                cama = dtDatosAtencion.Rows[0].Field<String>("cama");
                institucion = dtDatosAtencion.Rows[0].Field<String>("institucion");
                causaExterna = dtDatosAtencion.Rows[0].Field<String>("causaExterna");
                viaIngreso = dtDatosAtencion.Rows[0].Field<String>("viaIngreso");
            }
        }

        public void cargarDiagnosticoImpresion(IngresoClinico ingresoClinico)
        {
            IngresoClinicoDAL.cargarDiagnosticoImpresion(ingresoClinico);
        }
        public void cargarDatos(IngresoClinico ingresoClinico)
        {
            IngresoClinicoDAL.cargarDatos(ingresoClinico);
            DataTableCollection tabla = dsDatos.Tables;
            if (tabla["table"].Rows.Count > 0)
            {
                Peso = tabla["table"].Rows[0].Field<String>("peso");
                MotivoIngreso = tabla["table"].Rows[0].Field<String>("motivoingreso");
                AntecedentesMedicos = tabla["table"].Rows[0].Field<String>("AntecedentesMedicos");
                AntecedentesQuirurgicos = tabla["table"].Rows[0].Field<String>("AntecedentesQuirurgicos");
                AntecedentesTransfusionales = tabla["table"].Rows[0].Field<String>("AntecedentesTransfusionales");
                AntecedentesAlergicos = tabla["table"].Rows[0].Field<String>("AntecedentesAlergicos");
                AntecedentesTraumaticos = tabla["table"].Rows[0].Field<String>("AntecedentesTraumaticos");
                AntecedentesFamiliares = tabla["table"].Rows[0].Field<String>("AntecedentesFamiliares");
                RevisionSistema = tabla["table"].Rows[0].Field<String>("revisionSistema");
                SignosVitales = tabla["table"].Rows[0].Field<String>("SignosVitales");
                CabezaCuello = tabla["table"].Rows[0].Field<String>("cabezaCuello");
                CardioPulmonar = tabla["table"].Rows[0].Field<String>("cardioPulmonar");
                Abdomen = tabla["table"].Rows[0].Field<String>("abdomen");
                GenitalUrinario = tabla["table"].Rows[0].Field<String>("genitalurinario");
                Extremidades = tabla["table"].Rows[0].Field<String>("extremidades");
                SistemaNervioso = tabla["table"].Rows[0].Field<String>("sistemanervioso");
                Paraclinicos = tabla["table"].Rows[0].Field<String>("paraclinicos");
                Analisis = tabla["table"].Rows[0].Field<String>("analisis");
                Pronostico = tabla["table"].Rows[0].Field<String>("pronosticos");
                Torax = tabla["table"].Rows[0].Field<String>("torax");
                AntecedentesToxicos = tabla["table"].Rows[0].Field<String>("antecedentesToxicos");
                Generales = tabla["table"].Rows[0].Field<String>("generales");
                resumenClinico = tabla["table"].Rows[0].Field<String>("resumenClinico");
                pielFaneras = tabla["table"].Rows[0].Field<String>("pielFaneras");
            }
            if(tabla["table1"].Rows.Count > 0)
            {
                edadMadre = tabla["table1"].Rows[0]["edadMadre"].ToString();
                edadGestional = tabla["table1"].Rows[0]["edadGestional"].ToString();
                fum = tabla["table1"].Rows[0]["fum"].ToString();
                obstreticos = tabla["table1"].Rows[0]["obstetricos"].ToString();
                hemoclasificacionMadre = tabla["table1"].Rows[0]["hemoclasificacionMadre"].ToString();
                hemoclasificacionPadre = tabla["table1"].Rows[0]["hemoclasificacionPadre"].ToString();
                vacunacion = tabla["table1"].Rows[0]["Vacunacion"].ToString();
                preeclampcia = tabla["table1"].Rows[0]["Preeclampcia"].ToString();
                controlPrenatal = tabla["table1"].Rows[0]["ControlPrenatal"].ToString();
                medicamentoDuranteEmbarazo = tabla["table1"].Rows[0]["MedicamentoDuranteEmbarazo"].ToString();
                hipertensionGestacional = tabla["table1"].Rows[0]["HipertensionGestacional"].ToString();
                habitos = tabla["table1"].Rows[0]["Habitos"].ToString();
                infeccionEmbarazo = tabla["table1"].Rows[0]["InfeccionDuranteEmbarazo"].ToString();
                enfermedadTiroidea = tabla["table1"].Rows[0]["EnfermedadTiroidea"].ToString();
                diabeteGestacional = tabla["table1"].Rows[0]["DiabeteGestacional"].ToString();
                diabeteMellitius = tabla["table1"].Rows[0]["DiabeteMellitus"].ToString();
                torch = tabla["table1"].Rows[0]["Torch"].ToString();
            }
            if(tabla["table2"].Rows.Count > 0)
            {
                tipoParto= tabla["table2"].Rows[0]["tipoParto"].ToString();
                inducionParto = tabla["table2"].Rows[0]["InducionParto"].ToString();
                apgar1 = tabla["table2"].Rows[0]["Apgar1"].ToString();
                reanimacionNacer = tabla["table2"].Rows[0]["ReanimacionNacer"].ToString();
                rupturasMemb = tabla["table2"].Rows[0]["RupturasMemb"].ToString();
                caractLiquidas = tabla["table2"].Rows[0]["CaractLiquidas"].ToString();
                apgar5 = tabla["table2"].Rows[0]["Apgar5"].ToString();
            }
            if(tabla["table3"].Rows.Count > 0)
            {
                hemoclasificacion = tabla["table3"].Rows[0]["hemoclasificacion"].ToString();
                tsh = tabla["table3"].Rows[0]["tsh"].ToString();
                vdrl = tabla["table3"].Rows[0]["vdrl"].ToString();
                glucometrias = tabla["table3"].Rows[0]["glucometrias"].ToString();
            }
        }
    }
}
