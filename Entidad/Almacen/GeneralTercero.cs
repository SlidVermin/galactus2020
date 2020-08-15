using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidad.Almacen
{
    public class GeneralTercero
    {
        private DataTable dt = new DataTable();
        public string codigo { get; set; }
        public int codigoTercero { get; set; }
        public int codigoRegimen { get; set; }
        public int codigoUbicacion { get; set; }
        public int codigoFormaPago { get; set; }
        public string cuentaPuc { get; set; }
        public string cuentaCIIU { get; set; }
        public int diaPlazo { get; set; }
        public int diaEntrega { get; set; }
        public int diaDevolucion { get; set; }

        public GeneralTercero()
        {
            dt.Columns.Add("Codigo", Type.GetType("System.Int32"));
            dt.Columns.Add("Descripcion", Type.GetType("System.String"));
        }

        public DataTable llenarComboUbicacion()
        {
            DataRow dRows;
            dt.Clear();

            dRows = dt.NewRow();
            dRows[0] = 1;
            dRows[1] = "Nacional";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 2;
            dRows[1] = "Intenacional";
            dt.Rows.Add(dRows);

            return dt;
        }

        public DataTable llenarComboFormaPago()
        {
            DataRow dRows;
            dt.Clear();

            dRows = dt.NewRow();
            dRows[0] = 1;
            dRows[1] = "Efectivo";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 2;
            dRows[1] = "Credito";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 3;
            dRows[1] = "Contado";
            dt.Rows.Add(dRows);

            return dt;
        }
        public DataTable llenarComboTipoCuenta()
        {
            DataRow dRows;
            dt.Clear();

            dRows = dt.NewRow();
            dRows[0] = 1;
            dRows[1] = "Ahorro";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 2;
            dRows[1] = "Corriente";
            dt.Rows.Add(dRows);

            return dt;
        }
    }
}
