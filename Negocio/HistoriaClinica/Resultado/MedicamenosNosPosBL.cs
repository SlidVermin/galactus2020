using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.HistoriaClinica.Resultado
{
    public class MedicamenosNosPosBL
    {
       /* public void cargarDatos()
        {
            MedicamentoNoPosDAL.cargarDatos(this);
            DataTableCollection dtDatos = dsDatos.Tables;
            if (dtDatos["table"].Rows.Count > 0)
            {
                documento = dtDatos["table"].Rows[0]["DocumentoIdentificación"].ToString();
                paciente = dtDatos["table"].Rows[0]["Paciente"].ToString();
                edad = dtDatos["table"].Rows[0]["edad"].ToString();
                estancia = dtDatos["table"].Rows[0]["Estancia"].ToString();
                estado = dtDatos["table"].Rows[0]["Estado"].ToString();
                cama = dtDatos["table"].Rows[0]["Cama"].ToString();
                causaExterna = dtDatos["table"].Rows[0]["Causa Externa"].ToString();
                institucion = dtDatos["table"].Rows[0]["institucion"].ToString();
                fechaIngreso = Convert.ToDateTime(dtDatos["table"].Rows[0]["fecha ingreso"]);
                area = dtDatos["table"].Rows[0]["area"].ToString();
                entorno = dtDatos["table"].Rows[0]["entorno"].ToString();
            }
            if (dtDatos["table3"].Rows.Count > 0)
            {
                fechaSolicitud = Convert.ToDateTime(dtDatos["table3"].Rows[0]["fechaSolicitud"]);
                idMedicamentoActual = (int)dtDatos["table3"].Rows[0]["idEquivalenciaActual"];
                nombreMedicamentoActual = dtDatos["table3"].Rows[0]["Medicamento"].ToString();
                nombreMedicamentoNuevo = dtDatos["table3"].Rows[0]["MedicamentoNuevo"].ToString();
                idMedicamentoReemplazar = (int)dtDatos["table3"].Rows[0]["idEquivalenciaNuevo"];
                diasTratamiento = (int)dtDatos["table3"].Rows[0]["diasTratamiento"];
                dosis = dtDatos["table3"].Rows[0]["dosis"].ToString();
                frecuencia = dtDatos["table3"].Rows[0]["frecuencia"].ToString();
                dosisSolicitada = dtDatos["table3"].Rows[0]["dosisSolicitada"].ToString();
                resumenHC = dtDatos["table3"].Rows[0]["resumenhc"].ToString();
                otroPosUtilizado = (Boolean)dtDatos["table3"].Rows[0]["otroPosUtilizado"];
                respuestaPos = dtDatos["table3"].Rows[0]["respuestaPos"].ToString();
                efectoDeseado = dtDatos["table3"].Rows[0]["efectoDeseado"].ToString();
                indicacionEfecto = dtDatos["table3"].Rows[0]["indicacionEfecto"].ToString();
                explicacionRazon = dtDatos["table3"].Rows[0]["explicarRazon"].ToString();
                criterio1 = (Boolean)dtDatos["table3"].Rows[0]["CriterioEvaluacion1"];
                criterio2 = (Boolean)dtDatos["table3"].Rows[0]["CriterioEvaluacion2"];
                precaucionesOtros = dtDatos["table3"].Rows[0]["precaucionesyOtros"].ToString();
                peligro = dtDatos["table3"].Rows[0]["peligro"].ToString();
                posibilidadTerapeutica = (Boolean)dtDatos["table3"].Rows[0]["posibilidadTerapeutica"];
                reaccionesSecundaria = dtDatos["table3"].Rows[0]["reaccionSecundaria"].ToString();
                contraIndicaciones = dtDatos["table3"].Rows[0]["contraIndicaciones"].ToString();
                fechaCTC = (DateTime)dtDatos["table3"].Rows[0]["fechaCTC"];
                encabezadoCTC = dtDatos["table3"].Rows[0]["encabezadoctc"].ToString();
                decisionCTC = dtDatos["table3"].Rows[0]["decisionctc"].ToString();
                motivoIngreso = dtDatos["table3"].Rows[0]["motivoIngreso"].ToString();
            }
        }
        public void guardar()
        {
            prepararDT();
            MedicamentoNoPosDAL.guardarNoPos(this);
        }
        public void anular()
        {
            MedicamentoNoPosDAL.anular(this);
        }
        public void prepararDT()
        {
            DataTable dt = new DataTable();

            if (idSolicitud == -1)
            {
                dsDatos.Tables["table1"].AcceptChanges();
                dt = dsDatos.Tables["table1"].Copy();
            }
            else
            {
                dsDatos.Tables["table2"].AcceptChanges();
                dt = dsDatos.Tables["table2"].Copy();
            }
            dt.Columns.Remove("Código");
            dt.Columns.Remove("Descripcion");
            dtDiagnostico.Reset();
            agregarColumnaDiagnostico();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].Field<Boolean>("Asignar") == true)
                {
                    dtDiagnostico.ImportRow(dt.Rows[i]);
                }
            }
        }
        public void agregarColumnaDiagnostico()
        {
            dtDiagnostico.Columns.Add("Id", typeof(Int32));
            dtDiagnostico.Columns.Add("IdEvolucion", typeof(Int32));
        }*/
    }
}
