using Entidad.HistoriaClinica.Evolucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace Vista.HistoriaClinica.Evolucion
{
    public partial class ProblemasUI : Form
    {
        public EvolucionMedica evolucionMedica = new EvolucionMedica();
        public ProblemasUI()
        {
            InitializeComponent();
        }

        private void ProblemasUI_Load(object sender, EventArgs e)
        {
            establecerGridview();
        }

        public void establecerGridview()
        {
            /*evolucionMedica.establecerDt();

            dgvDiagnostico.Columns["dgId"].DataPropertyName = "Id";
            dgvDiagnostico.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvDiagnostico.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvDiagnostico.Columns["dgAgregar"].DataPropertyName = "Agregar";
            dgvDiagnostico.Columns["dgQuitar"].DataPropertyName = "Quitar";

            dgvDiagnostico.DataSource = evolucionMedica.dtDiagnostico;*/
        }
        public void cargarDiagnostico(DataRow filas)
        {
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgId"].Value = filas.Field<int>("Id");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripcion");
           
        }

        public void obtenerDiagnosticoCargar(DataTable dtDiagnostico)
        {
            evolucionMedica.dtDiagnostico = dtDiagnostico.Copy();
            dgvDiagnostico.DataSource = evolucionMedica.dtDiagnostico;
        }
        private void dgvDiagnostico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgAgregar"].Selected == true ||
               dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true)
            {
                try
                {
                    GeneralUI.agregarRegistroDatagridView(buscarDiagnostico, verificarFila, quitarFila, dgvDiagnostico, dgvDiagnostico.Columns["dgcodigo"].Index);

                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }
        public void quitarFila()
        {
            dgvDiagnostico.Rows.RemoveAt(dgvDiagnostico.CurrentCell.RowIndex);
        }
        public void verificarFila()
        {
            if (string.IsNullOrEmpty(dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()))
            {
                dgvDiagnostico.Rows.RemoveAt(dgvDiagnostico.CurrentCell.RowIndex);
            }
        }
        public void buscarDiagnostico()
        {
            /*List<string> parametros = new List<string>();

            GeneralUI.buscarDevuelveFila(Sentencias.GENERAL_BUSCAR_DIAGNOSTICO,
                                               parametros,
                                               new GeneralUI.cargarInfoFila(cargarDiagnostico),
                                               Mensajes.BUSQUEDA_PACIENTE, true);*/
        }
    }
}
