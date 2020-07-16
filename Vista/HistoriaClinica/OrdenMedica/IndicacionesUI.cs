using Entidad.HistoriaClinica.OrdenMedica;
using System;
using System.Windows.Forms;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class IndicacionesUI : Form
    {
        public bool edicion = false;
        public OrdenClinicaIndicacion indicacion;
        public IndicacionesUI()
        {
            InitializeComponent();
        }
        public IndicacionesUI(int idAtencion)
        {
            InitializeComponent();
            
        }
        private void IndiceacionesUI_Load(object sender, EventArgs e)
        {

        }

        private void txtIndicaciones_TextChanged(object sender, EventArgs e)
        {
            indicacion.indicacion = txtIndicaciones.Text;
        }

        private void IndiceacionesUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void visualizarIndicacionCargada()
        {
            txtIndicaciones.Text = indicacion.indicacion;
        }
    }
}
