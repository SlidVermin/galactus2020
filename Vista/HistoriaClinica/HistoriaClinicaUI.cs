using System;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica
{

    public partial class HistoriaClinicaUI : Form
    {
        /*private int idAtencion;
        private bool auditoria;
        private bool esNeonatal;
        private DateTime fechaEgreso;
        private HistoriaClinicaPaciente historiaClinica = new HistoriaClinicaPaciente();
        private EvolucionMedicaUI EvolucionMedica;
        private OrdenMedicaUI OrdenClinica;
        private ResultadoOrdenMedicaUI resulOrdenMedica;
        private IngresoClinicoUI ingreso;
        private EgresoUI egreso;
        private EstanciaUI  estancia;
        private  RemisionUI remision;
        private ResumenFacturaUI  resumen;*/
        public HistoriaClinicaUI()
        {
            InitializeComponent();
        }

        #region btnSalir      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }*/
        }
        #endregion        

        private void HistoriaClinicaUI_Load(object sender, EventArgs e)
        {

            /*ingreso = new IngresoClinicoUI(idAtencion, auditoria, esNeonatal);
            OrdenClinica = new OrdenMedicaUI(idAtencion, auditoria);
            EvolucionMedica = new EvolucionMedicaUI(idAtencion, auditoria);
            resulOrdenMedica = new ResultadoOrdenMedicaUI(idAtencion,Convert.ToInt32(auditoria));
            egreso = new EgresoUI (idAtencion, auditoria);
            resumen = new ResumenFacturaUI (idAtencion, auditoria);
            estancia = new EstanciaUI(idAtencion, auditoria);
            remision = new RemisionUI(idAtencion, auditoria);

            GeneralC.cargarFormularioEnPestana(tpIngresoClinico, ingreso);
            GeneralC.cargarFormularioEnPestana(tpOrdenMedica, OrdenClinica);
            GeneralC.cargarFormularioEnPestana(tpLaboratorios,resulOrdenMedica);
            GeneralC.cargarFormularioEnPestana(tpEvolucion, EvolucionMedica);
            GeneralC.cargarFormularioEnPestana(tpEgreso, egreso);
            GeneralC.cargarFormularioEnPestana(tpEstancia , estancia);
            GeneralC.cargarFormularioEnPestana(tpRemision, remision);
            GeneralC.cargarFormularioEnPestana(tpResumen, resumen);

            ingreso.historiaClinica(this);*/
        }
        /*public void obtenerDatosPaciente(ListadoPaciente listaPaciente, int idIngreso,bool vAuditoria,bool vEsNeonatal)
        {
            DataTable dtDatos = new DataTable();
            dtDatos = GeneralC.copiarNewDatatable(listaPaciente.dtPacientes, "Atencion", idIngreso);
            if (dtDatos.Rows.Count > 0)
            {
                txtAtencion.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Atencion"));
                txtAdmision.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Admision"));
                txtPaciente.Text = dtDatos.Rows[0].Field<String>("Paciente");
                txtEdad.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Edad"));
                tcHistoriaClinica.Text = dtDatos.Rows[0].Field<String>("Cliente");
                txtEstancia.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Estancia"));
                txtSexo.Text = dtDatos.Rows[0].Field<String>("Genero");
                txtServicio.Text = dtDatos.Rows[0].Field<String>("Entorno");
                txtfechaIngreso.Text = Convert.ToString(dtDatos.Rows[0].Field<DateTime>("Fecha ingreso"));
                fechaEgreso = (dtDatos.Rows[0].Field<DateTime>("Fecha egreso"));
                idAtencion = int.Parse(txtAtencion.Text);
                auditoria = vAuditoria;
                esNeonatal = vEsNeonatal;
            }
        }*/

        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            //historiaClinica.orden.nuevaOrden();
        }

        private void tsbGuardarIngreso_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tabHistoriaClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (tabHistoriaClinica.SelectedTab.Name == tpResumen .Name)
            {
                resumen.cargar(); 
            }*/
        }

        private void tabHistoriaClinica_Selecting(object sender, TabControlCancelEventArgs e)
        {
            /*if (tpIngresoClinico.Parent !=null && tabHistoriaClinica.SelectedTab.Name != tpIngresoClinico.Name && ingreso.valoracionUI.txtResumenClinico.Text.Equals(""))
            {
                MessageBox.Show("Por favor debe realizar el ingreso antes de ir a las otras opciones", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabHistoriaClinica.SelectedIndex = 0;
            }*/
        }
    }
}
