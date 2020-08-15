using Entidad.Almacen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Almacen
{
    public partial class ClienteUI : Form
    {
        private Cliente cliente;
        public ClienteUI()
        {
            InitializeComponent();
        }

        private void ClienteUI_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            GeneralUI.deshabilitarBotones(ref tstMenuPatron);
            GeneralUI.deshabilitarControles(this);
            iniciarCombos();
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralUI.deshabilitarBotones(ref tstMenuPatron);
            GeneralUI.habilitarControles(this);
            GeneralUI.deshabilitarControles(pnlInformacion);
            GeneralUI.limpiarControles(this);
            cliente.codigo = null;
            tsbBuscarNit.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralUI.deshabilitarBotones(ref tstMenuPatron);
                GeneralUI.deshabilitarControles(this);
                GeneralUI.limpiarControles(this);
                cliente.codigo = null;
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarCampos() == true) 
            {
                if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    try
                    {
                        crearNuevoCliente();
                        ClienteDAL.guardarCliente(cliente);
                        GeneralC.habilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;
                        MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }*/
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {

                if(ClienteDAL.anularCliente(cliente.codigo) == true) { 
                   GeneralC.deshabilitarBotones(ref tstMenuPatron);
                   GeneralC.limpiarControles(this);
                   GeneralC.deshabilitarControles(this);
                   btnSalir.Enabled = true;
                   tsbBuscar.Enabled = true;
                   tsbNuevo.Enabled = true;
                   MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                 } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_CLIENTE,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarCliente),
                                    Titulos.TITULO_BUSCAR_CLIENTE,
                                    true, 
                                    listaParametroOculto());*/

        }
        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_TERCERO_CLIENTE,
                                      parametro,
                                      new GeneralC.cargarInfoFila(cargarTercero),
                                      Titulos.TITULO_BUSCAR_TERCERO,
                                      true);*/
        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion

        private void cargarTercero(DataRow dRows)
        {
            cliente.codigoTercero = dRows.Field<int>("codigo");
            txtNit.Text = dRows.Field<string>("Nit");
            txtRazonSocial.Text = dRows.Field<string>("RazonSocial");
            txtDireccion.Text = dRows.Field<string>("Direccion");
            txtTelefono.Text = dRows.Field<string>("Telefono");
        }
        private void cargarCliente(DataRow dRows)
        {
            cliente.codigo = dRows.Field<int>("idCliente").ToString();
            cmbRegimen.SelectedValue = dRows.Field<int>("IdRegimen").ToString();
            cmbFormaPago.SelectedValue = dRows.Field<int>("IdFormaPago").ToString();
            cmbUbicacion.SelectedValue = dRows.Field<int>("idUbicacion").ToString();
            numEntrega.Value = dRows.Field<int>("Dia Entrega");
            numPlazo.Value = dRows.Field<int>("Dia Plazo");
            numDevolucion.Value = dRows.Field<int>("Dia Devolución");
            cargarTercero(dRows);
            GeneralUI.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
            btnSalir.Enabled = true;
        }
        private Boolean validarCampos()
        {
            if (txtNit.Text == string.Empty)
            {
                MessageBox.Show("¡ Favor seleccionar el tercero !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cmbRegimen.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccionar el regimen !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cmbFormaPago.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccionar la forma de pago !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cmbUbicacion.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccionar la ubicación !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void crearNuevoCliente()
        {
            cliente.codigoFormaPago = Convert.ToInt32(cmbFormaPago.SelectedValue);
            cliente.codigoRegimen = Convert.ToInt32(cmbRegimen.SelectedValue);
            cliente.codigoUbicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
            cliente.diaPlazo = Convert.ToInt32(numPlazo.Value);
            cliente.diaEntrega = Convert.ToInt32(numEntrega.Value);
            cliente.diaDevolucion = Convert.ToInt32(numDevolucion.Value);
        }

        private void iniciarCombos()
        {
            /*List<string> parametro = new List<string>();
            string cadena;
            parametro.Add(ConstanteGeneral.REGIMEN_SOCIO_ECONOMICO.ToString());
            cadena = GeneralC.obtenerParametros(parametro);
            GeneralC.llenarCombo(Sentencias.PARAMETROS_CONSULTAR_DESCRIPCION + cadena, "Codigo", "Descripcion", cmbRegimen);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboFormaPago(),"Codigo", "Descripcion", cmbFormaPago);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboUbicacion(),"Codigo", "Descripcion", cmbUbicacion);*/
        }
        private List<string> listaParametroOculto()
        {
            List<string> paramtro = new List<string>();
            paramtro.Add("idCliente");
            paramtro.Add("codigo");
            paramtro.Add("idRegimen");
            paramtro.Add("idFormaPago");
            paramtro.Add("idUbicacion");
            paramtro.Add("cuentaPuc");
            paramtro.Add("cuentaCIIU");
            paramtro.Add("NombrePuc");
            paramtro.Add("NombreCIIU");
            return paramtro;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(Mensajes.Modificar_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralUI.deshabilitarBotones(ref tstMenuPatron);
                GeneralUI.habilitarControles(this);
                GeneralUI.deshabilitarControles(pnlInformacion);
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }
        }

        private void pnlInformacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
