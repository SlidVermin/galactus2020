using Entidad.HistoriaClinica.Enfermeria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Vista.HistoriaClinica.Enfermeria
{
    public partial class InsumosUI : Form
    {
      public  EnfermeriaClinica enfermeria = new EnfermeriaClinica();
        public InsumosUI()
        {
            InitializeComponent();
        }

        private void InsumosUI_Load(object sender, EventArgs e)
        {
            establecerGridview();
        }
        public void establecerGridview()
        {
            /*enfermeria.establecerDT();
            dgvInsumos.Columns["dgId"].DataPropertyName = "Id";
            dgvInsumos.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvInsumos.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvInsumos.Columns["dgCantidad"].DataPropertyName = "Cantidad";
            dgvInsumos.Columns["dgAgregar"].DataPropertyName = "Agregar";
            dgvInsumos.Columns["dgQuitar"].DataPropertyName = "Quitar";

            dgvInsumos.DataSource = enfermeria.dtInsumos;*/
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgAgregar"].Selected == true ||
              dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true)
            {
                try
                {
                    GeneralUI.agregarRegistroDatagridView(buscarInsumos, verificarFila, quitarFila, dgvInsumos, dgvInsumos.Columns["dgcodigo"].Index);

                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }
        public void quitarFila()
        {
            dgvInsumos.Rows.RemoveAt(dgvInsumos.CurrentCell.RowIndex);
        }
        public void verificarFila()
        {
            if (string.IsNullOrEmpty(dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()))
            {
                dgvInsumos.Rows.RemoveAt(dgvInsumos.CurrentCell.RowIndex);
            }
        }
        public void buscarInsumos()
        {
            /*List<string> parametros = new List<string>();

            DataTable tablaParametros = new DataTable();
            DataTable tablasSeleccionado = new DataTable();

            tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
            tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

            DataView view = new DataView(enfermeria.dtInsumos);

            tablasSeleccionado = view.ToTable(true, new string[] { "id" }).Copy();
            tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
            object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

            tablaParametros.Rows.Add(myObjArray2);

            GeneralUI.buscarDevuelveFila(Sentencias.BUSCAR_INSUMOS_ENFERMERIA,
                                               parametros,
                                               new GeneralUI.cargarInfoFila(cargarInsumos),
                                               Mensajes.BUQEDA_INSUMOS, true,null, tablasSeleccionado,tablaParametros);*/
        }
        public void cargarInsumos(DataRow filas)
        {
            dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgId"].Value = filas.Field<int>("Id");
            dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código");
            dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripción");

        }
    }
}
