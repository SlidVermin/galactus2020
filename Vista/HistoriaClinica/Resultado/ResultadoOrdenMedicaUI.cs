using System;
using System.Windows.Forms;


namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class ResultadoOrdenMedicaUI : Form
    {
        private int idAtencion;
        private int auditoria;
//        private LaboratorioUI laboratorio;

        public ResultadoOrdenMedicaUI(int idAtencion, int auditoria)
        {
            InitializeComponent();

            this.idAtencion = idAtencion;
            this.auditoria = auditoria;

        }

        private void ResultadoOrdenMedicaUI_Load(object sender, EventArgs e)
        {
            /*GeneralUI.deshabilitarControles(this);
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());

            laboratorio = new LaboratorioUI(idAtencion,auditoria,ConstanteGeneral.ID_LABORATORIO);
            laboratorio.resulOrdenMedica = this;
            GeneralUI.cargarFormularioEnPestana(tpLaboratorio, laboratorio);*/            
        }

    }
}
