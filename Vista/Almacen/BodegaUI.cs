using Entidad.Almacen;
using System;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Almacen
{
    public partial class BodegaUI : Form
    {
        Bodega bodega = new Bodega();
        public BodegaUI()
        {
            InitializeComponent();
        }
        private void BodegaUI_Load(object sender, EventArgs e)
        {
            GeneralUI.colocarIconosMenu(tstMenuPatron);
            GeneralUI.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        #region Metodos y funciones
        bool validarForm()
        {
            bool resp = false;
            if (txtDescripcion.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe colocar la descripción de la bodega");
            }
            else
            {
                resp = true;
            }
            return resp;
        }
        void cargarBodega(DataRow fila)
        {
            txtCodigo.Text = fila.Field<int>(0).ToString();
            txtDescripcion.Text = fila.Field<string>(1);
            GeneralUI.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular);
        }
        #endregion
        #region Eventos de botones
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarForm())
            {
                if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bodega.idBodega = (txtCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtCodigo.Text));
                    bodega.descripcion = txtDescripcion.Text;

                    try
                    {
                        BodegaDAL.guardar(bodega);
                        GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                        txtCodigo.Text = bodega.idBodega.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }*/
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Sentencias.ALMACEN_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarBodega),
                                            Mensajes.BUSQUEDA_BODEGA,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BodegaDAL.anular(bodega);
                    GeneralC.posAnular(this,  tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }*/
        }

        #endregion

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
