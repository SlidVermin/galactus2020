using Modelo.Facturacion;
using Modelo.Facturacion;
using Modelo.General;
using Modelo.General.Instrucciones;
using Modelo.General;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Facturacion
{
    public class FacturaPacienteBL
    {
        public void guardar(FacturaPaciente facturaPaciente)
        {
            DataSet dsCambios = prepararDS(new DataSet());
            FacturaPacienteDAL.guardar(facturaPaciente);
        }

        public DataSet prepararDS(DataSet dsDatos)
        {
            DataSet dsCambios = new DataSet();
            DataTable dtCambiosCUPS = new DataTable();
            DataTable dtCambiosOxigeno = new DataTable();
            DataTable dtCambiosEquivalencia = new DataTable();

            dtCambiosCUPS = dsDatos.Tables["table"].Copy();
            dtCambiosOxigeno = dsDatos.Tables["table1"].Copy();
            dtCambiosEquivalencia = dsDatos.Tables["table2"].Copy();

            dtCambiosCUPS.Columns.Remove("Descripción");
            dtCambiosCUPS.Columns.Remove("Código");
            dtCambiosCUPS.Columns.Remove("Total");
            dtCambiosOxigeno.Columns.Remove("Descripción");
            dtCambiosOxigeno.Columns.Remove("Código");
            dtCambiosOxigeno.Columns.Remove("Total");
            dtCambiosEquivalencia.Columns.Remove("Descripción");
            dtCambiosEquivalencia.Columns.Remove("Código");
            dtCambiosEquivalencia.Columns.Remove("Total");

            dsCambios.Tables.Add(dtCambiosCUPS);
            dsCambios.Tables.Add(dtCambiosOxigeno);
            dsCambios.Tables.Add(dtCambiosEquivalencia);

            return dsCambios;       
        }                           

        public void anular(FacturaPaciente facturaPaciente)
        {
            FacturaPacienteDAL.eliminar(facturaPaciente);
        }

        public void cargarDatos(FacturaPaciente facturapaciente)
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(facturapaciente.idAdmision));
            param.Add(Convert.ToString(facturapaciente.tipoFactura));

            DataSet dsDatos = OperacionesBD.llenarDataset(SentenciasDAL.FACTURA_PACIENTE_CARGAR_ADMISION, param);
            facturapaciente.totalFactura = Convert.ToDouble(dsDatos.Tables["table3"].Rows[0]["total"].ToString());
        }
    }
}
