using Entidad.HistoriaClinica.Resultado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    public partial class JustificacionAntibioticoUI : Form
    {

        JustificacionAntibiotico JustificacionAnt = new JustificacionAntibiotico();
        public JustificacionAntibioticoUI()
        {
            InitializeComponent();
        }

        private void JustificacionAntibioticoUI_Load(object sender, EventArgs e)
        {
            //txtFechaSolicitud.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
           
        }
        private void cargarInformacion(DataRow dRows) {

    
       
        }
      

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(JustificacionAnt.auditoria));
                List<string> listaOculta = new List<string>();
                listaOculta.Add("idEquivalencia");
                listaOculta.Add("idJustificacionAntibiotico");
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_ORDEN_MEDICA_JUSTIFICACION_ANT,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true, listaOculta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        public void cargarRegistro(DataRow resultado)
        {
            GeneralUI.limpiarControles(this);
            /*JustificacionAnt.idAtencion = resultado.Field<int>("Atencion");
            JustificacionAnt.idOrdenMedica = resultado.Field<int>("Código orden");
            JustificacionAnt.idJustificacion = resultado.Field<int>("idJustificacionAntibiotico");
            JustificacionAnt.nombreMedicamentoActual = resultado.Field<String>("Medicamento");
            JustificacionAnt.idMedicamentoActual = resultado.Field<int>("idEquivalencia");
            JustificacionAnt.cargarDatos();
            datos();
            dgvDiagnostico.DataSource = JustificacionAnt.dsDatos.Tables["table1"];
            dgvDiagnostico.ReadOnly = false;         */

        }
        public void datos()
        {
            txtAtencion.Text = Convert.ToString( JustificacionAnt.idAtencion);
            txtHistoriaClinica.Text = JustificacionAnt.documentoIdentidad;
            txtPaciente.Text = JustificacionAnt.paciente;
            txtEdad.Text = JustificacionAnt.edad;
            txtEstancia.Text = JustificacionAnt.estancia;
            txtArea.Text = JustificacionAnt.area;
            txtEntorno.Text = JustificacionAnt.entorno;
            txtViaIngreso.Text = JustificacionAnt.viaIngreso;
            txtCausaExterna.Text = JustificacionAnt.causaExterna;
            txtOrdenMedica.Text = Convert.ToString(JustificacionAnt.idOrdenMedica);
            txtCama.Text = JustificacionAnt.cama;
        }
    }
}
