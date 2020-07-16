using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.HistoriaClinica.Configuracion
{
    public class ConfiguracionProcedimientoMedico
    {
        public int idConfiguracion { get; set; }
        public string idItem { get; set; }
        public string descripcionItem { get; set; }
        public string descripcionCliente { get; set; }
        public int idCliente { get; set; }
        public int usuario { get; set; }
        public Boolean moduloHc { get; set; }
        public Boolean moduloFc { get; set; }
        public Boolean noRepetible { get; set; }
        public Boolean paquete { get; set; }
        public string tipo { get; set; }
        public  DataTable tablaAreaAtencion { get; set; }
        public  DataTable tablaProcedimiento { get; set; }
        public  DataTable tablaMedicamentoInsumo { get; set; }
        //public BindingSource enlace;
        public ConfiguracionProcedimientoMedico() {
                tablaAreaAtencion = new DataTable();
                tablaProcedimiento = new DataTable();
                tablaMedicamentoInsumo = new DataTable();

                tablaAreaAtencion.Columns.Add("Código", Type.GetType("System.String"))       ;
                tablaAreaAtencion.Columns.Add("Descripción", Type.GetType("System.String")) ;
                tablaAreaAtencion.Columns.Add("Cantidad", Type.GetType("System.String"));

                tablaProcedimiento.Columns.Add("Código", Type.GetType("System.String"));
                tablaProcedimiento.Columns.Add("Descripción", Type.GetType("System.String"));
                tablaProcedimiento.Columns.Add("Cantidad", Type.GetType("System.Int32"));

                tablaMedicamentoInsumo.Columns.Add("Código", Type.GetType("System.String"));
                tablaMedicamentoInsumo.Columns.Add("Descripción", Type.GetType("System.String"));
                tablaMedicamentoInsumo.Columns.Add("Cantidad", Type.GetType("System.Int32"));
        }
        public DataTable construirTabla()
        {
            string expresion;
            expresion = "Codigo != ''";
            DataTable tablaResultado = new DataTable();
            DataRow[] filas;
            filas = tablaProcedimiento.Select(expresion, "");

            foreach (var fila in filas)
            {
                tablaResultado.ImportRow(fila);
            }
            filas = tablaAreaAtencion.Select(expresion, "");
            foreach (var fila in filas)
            {
                tablaResultado.ImportRow(fila);
            }
            filas = tablaMedicamentoInsumo.Select(expresion, "");
            foreach (var fila in filas)
            {
                tablaResultado.ImportRow(fila);
            }

            return tablaResultado;
        }
    }
}

