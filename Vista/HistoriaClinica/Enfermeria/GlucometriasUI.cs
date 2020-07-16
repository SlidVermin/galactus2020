using Entidad.HistoriaClinica.Enfermeria;
using System;
using System.Windows.Forms;


namespace Vista.HistoriaClinica.Enfermeria
{
    public partial class GlucometriasUI : Form
    {
        EnfermeriaClinica enfermeria = new EnfermeriaClinica();
        public GlucometriasUI()
        {
            InitializeComponent();
        }

        private void GlucometriasUI_Load(object sender, EventArgs e)
        {
            establecerDatagridview();
        }

        public void establecerDatagridview()
        {
            dgvGlucometria.Columns["dgId"].DataPropertyName = "Id";
            dgvGlucometria.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvGlucometria.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvGlucometria.Columns["dgHora"].DataPropertyName = "Hora";
            dgvGlucometria.Columns["dgGlicemia"].DataPropertyName = "Glicemia";
            dgvGlucometria.Columns["dgInsulina"].DataPropertyName = "Insulina";
            dgvGlucometria.Columns["dgResponsable"].DataPropertyName = "Responsable";
            dgvGlucometria.Columns["dgUsuario"].DataPropertyName = "Usuario";
        }
    }
}
