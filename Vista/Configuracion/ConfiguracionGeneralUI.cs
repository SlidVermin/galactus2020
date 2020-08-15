using Entidad.Configuracion;
using System;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Configuracion
{
    public partial class ConfiguracionGeneralUI : Form
    {
        ConfiguracionGeneral objConfiguracionGeneral = new ConfiguracionGeneral();
        public ConfiguracionGeneralUI()
        {
            InitializeComponent();
        }
        private void ConfiguracionGeneralUI_Load(object sender, EventArgs e)
        {
            GeneralUI.posCargadoForm(this,  tstMenuPatron);
            DataGridViewColumnCollection columnas = dgvDetalle.Columns;
            columnas["Código"].DataPropertyName = "Código";
            columnas["Descripción"].DataPropertyName = "Descripción";
            tsbBuscarParametro.Enabled = true;
            dgvDetalle.Enabled = true;
            btlimpiar.Enabled = true;
        }
        void cargarParametro(DataRow fila)
        {
            objConfiguracionGeneral.idParametro = fila.Field<int>("Código");
            txtBParametro.Text = fila.Field<string>("Descripción");
            txtBCodigo.ResetText();
            txtDescripción.ResetText();
            txtDescripción.Enabled = true;
            tsbGuardar.Enabled = true;
            llenarGrilla();
        }
        void llenarGrilla()
        {
                objConfiguracionGeneral.llenarDocumentos();
                enlazarGrilla();
                txtBusqueda.Enabled = true;
        }
        void enlazarGrilla()
        {
            /*dgvDetalle.DataSource = objConfiguracionGeneral.enlace.DataSource;
            dgvDetalle.Enabled = true;*/
        }
        bool validarForm()
        {
            if (txtBParametro.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger el parametro padre ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsbBuscarParametro.Focus();
                return false;
            }
            else if (txtDescripción.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la descripción del parametro ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripción.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        void posAccion()
        {
            txtBCodigo.Text = "";
            txtDescripción.Text = "";
            tsbAnular.Enabled = false;
            tsbBuscarParametro.Enabled = true;
            btlimpiar.Enabled = true;
            txtDescripción.Enabled = true;
            llenarGrilla();
        }
        private void tsbBuscarParametro_Click(object sender, EventArgs e)
        {
            /*List<string> parametros = new List<string>();
            parametros.Add("");
            GeneralC.buscarDevuelveFila(Sentencias.PARAMETROS_CARGAR,
                                        parametros,
                                        new GeneralC.cargarInfoFila(cargarParametro),
                                        "Busqueda de Parametros",
                                        true);*/
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objConfiguracionGeneral.idDocumento = (txtBCodigo.Text.Equals("") ? -1 : int.Parse(txtBCodigo.Text));
                    objConfiguracionGeneral.descripcionDocumento = txtDescripción.Text;
                    ConfiguracionGeneralDAL.guardar(objConfiguracionGeneral);
                    MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    posAccion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
        private void btlimpiar_Click(object sender, EventArgs e)
        {
            txtDescripción.ResetText();
            txtBCodigo.ResetText();
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (txtDescripción.Text.Equals("") && txtBCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger un parametro hijo para anularlo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(Mensajes.ANULAR_FORM, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ConfiguracionGeneralDAL.anular(objConfiguracionGeneral);
                        MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        posAccion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }*/
        }
        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                objConfiguracionGeneral.enlace.Filter = "[Descripción] like '%" + txtBusqueda.Text + "%'";
                enlazarGrilla();
            }*/
        }
        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (GeneralUI.filaValida(e.RowIndex))
            {
                objConfiguracionGeneral.idDocumento = int.Parse(dgvDetalle["Código", e.RowIndex].Value.ToString());
                objConfiguracionGeneral.descripcionDocumento = dgvDetalle["Descripción", e.RowIndex].Value.ToString();
                txtBCodigo.Text = dgvDetalle["Código", e.RowIndex].Value.ToString();
                txtDescripción.Text = dgvDetalle["Descripción", e.RowIndex].Value.ToString();
                txtDescripción.Enabled = true;
                tsbGuardar.Enabled = true;
                tsbAnular.Enabled = true;
            }*/
        }

    }
}
