using Modelo.General.Constantes;
using System;
using System.Data;

namespace Negocio.HistoriaClinica.OrdenMedica.Medicamentos
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
        public OrdenClinicaMedicamento()
        {
            tblMedicamentos = new DataTable();
            tblMedicamentos.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("idEquivalencia", Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("Descripción", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("tipoMedicamento", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("idViaAdmon", Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("Via admin.", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Dosis", Type.GetType("System.Double"));
            tblMedicamentos.Columns["Dosis"].DefaultValue = 0.0;
            tblMedicamentos.Columns.Add("Unidad", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Horario", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Hora inicial", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Dias Tto", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Suspender", Type.GetType("System.Boolean"));

            tblInfusionImpregnacion = new DataTable();
            tblInfusionImpregnacion.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("tipo", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("idEquivalencia", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("Descripción", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("tipoMedicamento", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Dosis", Type.GetType("System.Double"));
            tblInfusionImpregnacion.Columns["Dosis"].DefaultValue = 0.0;
            tblInfusionImpregnacion.Columns.Add("Unidad", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("cc/hora", Type.GetType("System.Double"));
            tblInfusionImpregnacion.Columns["cc/hora"].DefaultValue = 0.0;
            tblInfusionImpregnacion.Columns.Add("idEquivalenciaDisolvente", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("Disolvente", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("Hora inicial", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Mezcla", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Dias Tto", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Suspender", Type.GetType("System.Boolean"));
            tblInfusionImpregnacion.Columns.Add("Acepta disolvente", Type.GetType("System.Boolean"));


            tblMezcla = new DataTable();
            tblMezcla.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            tblMezcla.Columns.Add("idEquivalencia", Type.GetType("System.Int32"));
            tblMezcla.Columns.Add("Descripción", Type.GetType("System.String"));
            tblMezcla.Columns.Add("Unidad", Type.GetType("System.String"));
            tblMezcla.Columns.Add("Dosis", Type.GetType("System.Double"));
            tblMezcla.Columns["Dosis"].DefaultValue = 0.0;
        }
        public void homologarHorario()
        {
            int i;
            for (i = 0; i < tblMedicamentos.Rows.Count ; i++){
                switch (tblMedicamentos.Rows[i]["Horario"].ToString())
                {
                    case ConstanteGeneral.HORARIO_MEDICAMENTO_POR_DEFINIR:
                        tblMedicamentos.Rows[i]["Horario"] = ConstanteGeneral.POR_DEFINIR;
                        break;
                    case ConstanteGeneral.HORARIO_MEDICAMENTO_CODIGO_AZUL:
                        tblMedicamentos.Rows[i]["Horario"] = ConstanteGeneral.CODIGO_AZUL;
                        break;
                    case ConstanteGeneral.HORARIO_MEDICAMENTO_AHORA:
                    tblMedicamentos.Rows[i]["Horario"] = ConstanteGeneral.AHORA;
                        break;
                    case ConstanteGeneral.HORARIO_MEDICAMENTO_RAZON_NECESARIA:
                    tblMedicamentos.Rows[i]["Horario"] = ConstanteGeneral.RAZON_NECESARIA;
                        break;
                }
                switch (tblMedicamentos.Rows[i]["Hora inicial"].ToString())
                {
                    case ConstanteGeneral.HORARIO_MEDICAMENTO_POR_DEFINIR:
                        tblMedicamentos.Rows[i]["Hora inicial"] = ConstanteGeneral.POR_DEFINIR;
                        break;
                }
            }


            for (i = 0; i < tblInfusionImpregnacion.Rows.Count; i++)
            {
                switch (tblInfusionImpregnacion.Rows[i]["Hora inicial"].ToString())
                {
                    case ConstanteGeneral.HORARIO_MEDICAMENTO_POR_DEFINIR:
                        tblInfusionImpregnacion.Rows[i]["Hora inicial"] = ConstanteGeneral.POR_DEFINIR;
                        break;
                }
            }
        }
        public void prepararDT()
        {
            dtCambiosMedicamento = tblMedicamentos.Copy();
            dtCambiosInfusionImpregnacion = tblInfusionImpregnacion.Copy();
            dtCambiosMezcla = tblMezcla.Copy();

            dtCambiosMedicamento.Rows.RemoveAt(dtCambiosMedicamento.Rows.Count - 1);
            dtCambiosInfusionImpregnacion.Rows.RemoveAt(dtCambiosInfusionImpregnacion.Rows.Count - 1);

            dtCambiosMedicamento.Columns.Remove("Descripción");
            dtCambiosMedicamento.Columns.Remove("Via admin.");
            dtCambiosMedicamento.Columns.Remove("Unidad");
            dtCambiosMedicamento.Columns.Remove("Dias Tto");
            dtCambiosInfusionImpregnacion.Columns.Remove("Descripción");
            dtCambiosInfusionImpregnacion.Columns.Remove("Tipo");
            dtCambiosInfusionImpregnacion.Columns.Remove("Unidad");
            dtCambiosInfusionImpregnacion.Columns.Remove("Dias Tto");
            dtCambiosInfusionImpregnacion.Columns.Remove("Disolvente");
            dtCambiosInfusionImpregnacion.Columns.Remove("Acepta disolvente");
            dtCambiosInfusionImpregnacion.Columns.Remove("Mezcla");
            dtCambiosMezcla.Columns.Remove("Descripción");
            dtCambiosMezcla.Columns.Remove("Unidad");
            int i;
            for (i = 0; i < dtCambiosMedicamento.Rows.Count; i++)
            {
                dtCambiosMedicamento.Rows[i]["Suspender"] = (string.IsNullOrEmpty(dtCambiosMedicamento.Rows[i]["Suspender"].ToString()) ?
                                                                    false:
                                                                    dtCambiosMedicamento.Rows[i]["Suspender"]);
                switch (dtCambiosMedicamento.Rows[i]["Horario"].ToString())
                {
                    case ConstanteGeneral.POR_DEFINIR:
                          dtCambiosMedicamento.Rows[i]["Horario"] = ConstanteGeneral.HORARIO_MEDICAMENTO_POR_DEFINIR;
                          break;
                    case ConstanteGeneral.CODIGO_AZUL:
                          dtCambiosMedicamento.Rows[i]["Horario"] = ConstanteGeneral.HORARIO_MEDICAMENTO_CODIGO_AZUL;
                        break;
                    case ConstanteGeneral.AHORA:
                            dtCambiosMedicamento.Rows[i]["Horario"] = ConstanteGeneral.HORARIO_MEDICAMENTO_AHORA;
                        break;
                    case ConstanteGeneral.RAZON_NECESARIA:
                          dtCambiosMedicamento.Rows[i]["Horario"] = ConstanteGeneral.HORARIO_MEDICAMENTO_RAZON_NECESARIA;
                        break;
                }

                switch (dtCambiosMedicamento.Rows[i]["Hora inicial"].ToString())
                {
                    case ConstanteGeneral.POR_DEFINIR:
                        dtCambiosMedicamento.Rows[i]["Hora inicial"] = ConstanteGeneral.HORARIO_MEDICAMENTO_POR_DEFINIR;
                        break;
                }
            }
            for (i = 0; i < dtCambiosInfusionImpregnacion.Rows.Count; i++)
            {
                dtCambiosInfusionImpregnacion.Rows[i]["Suspender"] = (string.IsNullOrEmpty(dtCambiosInfusionImpregnacion.Rows[i]["Suspender"].ToString()) ?
                                                                    false :
                                                                    dtCambiosInfusionImpregnacion.Rows[i]["Suspender"]);
                switch (dtCambiosInfusionImpregnacion.Rows[i]["Hora inicial"].ToString())
                {
                    case ConstanteGeneral.POR_DEFINIR:
                        dtCambiosInfusionImpregnacion.Rows[i]["Hora inicial"] = ConstanteGeneral.HORARIO_MEDICAMENTO_POR_DEFINIR;
                        break;
                }
            }
        }

        public void quitarMezcla(int idMedicamento)
        {
            int i;
            for (i=0;i<tblMezcla.Rows.Count;i++)
            {
                if (int.Parse(tblMezcla.Rows[i]["idMedicamento"].ToString())  == idMedicamento)
                {
                    tblMezcla.Rows[i].Delete();
                }
                
            }
            tblMezcla.AcceptChanges();
        }
       

        public int obtenerConsecutivo()
        {
            consecutivoActual = consecutivoActual + 1;
            return consecutivoActual * -1;
        }
    }
}
