using System;
using System.Collections.Generic;
using System.Data;

namespace Entidad.HistoriaClinica
{
   public class IngresoClinico
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
        
    }
}
