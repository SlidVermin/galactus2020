using Entidad.HistoriaClinica.Resultado;
using System;
using System.Data;
using System.Windows.Forms;
using Vista.HistoriaClinica.Resultado;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class LaboratorioUI : Form
    {
        private int idAtencion;
        private int auditoria;
        private int paraclinico;
        private ResultadoOrdenMedica resultadoLaboratorio = new ResultadoOrdenMedica();
        public ResultadoOrdenMedicaUI resulOrdenMedica;
        private int contador;

        public LaboratorioUI(int idAtencion, 
                             int Auditoria,
                             int paraclinico)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = Auditoria;
            this.paraclinico = paraclinico;
        }

        private void LaboratorioUI_Load(object sender, EventArgs e)
        {
            validarGrilla();
            cargarExamenesLaboratorio();
        }

        private void cargarExamenesLaboratorio() {
           /* List<string> paramtro = new List<string>();
            paramtro.Add(auditoria.ToString());
            paramtro.Add(idAtencion.ToString());
            paramtro.Add(paraclinico.ToString());
            resultadoLaboratorio.dtResultado = GeneralC.cargarResultadosSQL(Sentencias.LISTAR_RESULTADO_LABORATORIO, paramtro);
            dgvResultadoLaboratorio.DataSource = resultadoLaboratorio.dtResultado;*/
        }

        private void validarGrilla() {
            dgvResultadoLaboratorio.Columns["dgIdSolicitud"].DataPropertyName= "idSolicitud";
            dgvResultadoLaboratorio.Columns["dgIdProcedimiento"].DataPropertyName = "idProcedimiento";
            dgvResultadoLaboratorio.Columns["dgDescripcionProcedimiento"].DataPropertyName = "Descripcion";
            dgvResultadoLaboratorio.Columns["dgLectura"].DataPropertyName = "Lectura"; ;
            dgvResultadoLaboratorio.AutoGenerateColumns = false;
        }
        private void dgvResultadoLaboratorio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ResultadoLaboratorioUI resultadoLaboratorio;
            int idSolicitud;
            int idOrdenMedica;
            int idProcedimiento;

            if (e.ColumnIndex == 3)
            {
                idSolicitud= Convert.ToInt32(dgvResultadoLaboratorio.Rows[dgvResultadoLaboratorio.CurrentCell.RowIndex].Cells["dgIdSolicitud"].Value);
                idOrdenMedica = Convert.ToInt32(resulOrdenMedica.txtBCodigoOrden.Text);
                idProcedimiento= Convert.ToInt32(dgvResultadoLaboratorio.Rows[dgvResultadoLaboratorio.CurrentCell.RowIndex].Cells["dgIdProcedimiento"].Value);
                resultadoLaboratorio = new ResultadoLaboratorioUI(idOrdenMedica, idProcedimiento, auditoria, idSolicitud);
                resultadoLaboratorio.cargarInformacionADatos();
                resultadoLaboratorio.Show();
            }
        }
        private void dgvResultadoLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resultadoLaboratorio.dtResultado.Rows.Count > 0) {
                resulOrdenMedica.txtBCodigoOrden.Text = resultadoLaboratorio.dtResultado.Rows[dgvResultadoLaboratorio.CurrentCell.RowIndex].Field<int>("idOrdenMedica").ToString();
                resulOrdenMedica.dtpFecha.Value = resultadoLaboratorio.dtResultado.Rows[dgvResultadoLaboratorio.CurrentCell.RowIndex].Field<DateTime>("Fecha");
            }
        }
    }
}
