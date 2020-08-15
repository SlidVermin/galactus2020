using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Entidad.Configuracion;
using Vista.General;

namespace Vista.Configuracion
{
    public partial class EmpresaUI : Form
    {
        Empresa empresa = new Empresa();
        #region Eventos de otros controles
        public EmpresaUI()
        {
            InitializeComponent();
        }
        private void EmpresaUI_Load(object sender, EventArgs e)
        {
            GeneralUI.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            iniciarlizarForm();
        }
        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            //GeneralC.llenarComboDependiente(cmbPais, cmbDepartamento, Sentencias.CARGAR_DEPARTAMENTO);
        }
        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //GeneralC.llenarComboDependiente(cmbDepartamento, cmbCiudad, Sentencias.CARGAR_MUNICIPIO);
        }
        private void Textnit_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (txtNit.Text.Equals(string.Empty))
                {
                    txtBDv.Text = string.Empty;
                }
                else
                {
                    DigitoVerificacion digitoVerificacion = new DigitoVerificacion();
                    txtBDv.Text = digitoVerificacion.calculaNit(txtNit.Text).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }
            */


        }
        #endregion
        #region Botones
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiarObjetoEmpresa();
            GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
            //GeneralC.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            //GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //asignarDatosEmpresa();
                //EmpresaDAL.guardar(empresa);
               //GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
            }
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*List<string> parametros = new List<string>();
            parametros.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Sentencias.EMPRESA_BUSCAR,
                                        parametros,
                                        new GeneralC.cargarInfoFila(cargarEmpresa),
                                        Mensajes.BUSQUEDA_EMPRESA,
                                        true);*/
                      
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    //EmpresaDAL.anular(empresa);
                    //GeneralUI.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
            }
        }
        private void tsbBuscarTercero_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_TERCERO,
                                        parametro,
                                        new GeneralC.cargarInfoFila(cargarTercero),
                                        Util.Titulos.TITULO_BUSCAR_TERCERO,
                                        true);*/
        }
        private void btlogo_Click(object sender, EventArgs e)
        {
            GeneralUI.seleccionarImagen(picLogo);
        }
        #endregion
        #region Metodos
        public void cargarTercero(DataRow fila)
        {
            empresa.idResponsable = fila.Field<int>("Código");
            txtIdentificacionRepresentante.Text = fila.Field<string>("Nit");
            txtNombreResponsable.Text = fila.Field<string>("RazonSocial");
        }
        public void cargarEmpresa(DataRow fila)
        {
            /*empresa.idEmpresa = fila.Field<int>("Código");
            List<string> parametros = new List<string>();
            parametros.Add(empresa.idEmpresa.ToString());
            DataRow filaResultado = GeneralC.devuelveUnaFila(Sentencias.EMPRESA_CARGAR, parametros);
            if (filaResultado != null)
            {
                empresa.nit = filaResultado.Field<string>("Nit");
                empresa.razonSocial = filaResultado.Field<string>("RazonSocial");
                empresa.codigoHabilitacion = filaResultado.Field<string>("CodigoHabilitacion");
                empresa.ubicacion = filaResultado.Field<int>("IdMunicipio");
                empresa.direccion = filaResultado.Field<string>("Direccion");
                empresa.telefono = filaResultado.Field<string>("Telefono");
                empresa.celular = filaResultado.Field<string>("Celular");
                empresa.email = filaResultado.Field<string>("Email");
                empresa.sigla = filaResultado.Field<string>("Sigla");
                empresa.encabezado = filaResultado.Field<string>("EncabezadoFactura");
                empresa.pie = filaResultado.Field<string>("PieFactura");
                empresa.logo = filaResultado.Field<byte[]>("Logo");
                empresa.idResponsable = filaResultado.Field<int>("IdTercero");

                txtNit.Text = empresa.nit;
                txtNombre.Text = empresa.razonSocial;
                txtDireccion.Text = empresa.direccion;
                txtTelefono.Text = empresa.telefono;
                txtCelular.Text = empresa.celular;
                txtMail.Text = empresa.email;
                txtEncabezado.Text = empresa.encabezado;
                txtPie.Text = empresa.pie;
                picLogo.Image = null;
                if (empresa.logo != null)
                {
                    using (MemoryStream memSt = new MemoryStream(empresa.logo))
                    {
                        picLogo.Image = Image.FromStream(memSt);
                    }
                }

                txtIdentificacionRepresentante.Text = filaResultado.Field<string>("identificacion");
                txtNombreResponsable.Text = filaResultado.Field<string>("nombreTercero");
                cmbPais.SelectedValue = filaResultado.Field<int>("IdPais");
                cmbDepartamento.SelectedValue = filaResultado.Field<int>("IdDepartamento");
                cmbCiudad.SelectedValue = empresa.ubicacion;
                GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular);
            }*/
        }
        void iniciarlizarForm()
        {
            /*GeneralC.llenarCombo(Sentencias.CARGARPAIS,
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 cmbPais);*/
        }
        bool validarForm()
        {
            /*if (txtNit.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar el nit !", txtNit);
                return false;
            }
                        else if (txtNombre.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar la razon social de la empresa !", txtNombre);
                return false;
            }
            else if (txtDireccion.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar la dirección de la empresa !", txtDireccion);
                return false;
            }
            else if (txtTelefono.Text.Equals("") && txtCelular.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar algún contacto para la empresa !", txtTelefono);
                return false;
            }
            else if (cmbPais.SelectedValue.Equals(Util.Constantes.ConstanteGeneral.PREDETERMINADA) || cmbPais.SelectedValue == null)
            {
                GeneralUI.mostrarMensajeInformacio("Debe escojer el pais !", cmbPais);
                return false;
            }
            else if (cmbDepartamento.SelectedValue.Equals(Util.Constantes.ConstanteGeneral.PREDETERMINADA) || cmbDepartamento.SelectedValue == null)
            {
                GeneralUI.mostrarMensajeInformacio("Debe escojer el departamento !", cmbDepartamento);
                return false;
            }
            else if (cmbCiudad.SelectedValue.Equals(Util.Constantes.ConstanteGeneral.PREDETERMINADA) || cmbCiudad.SelectedValue == null)
            {
                GeneralUI.mostrarMensajeInformacio("Debe escojer la municipio !", cmbCiudad);
                return false;
            }
            else if (txtIdentificacionRepresentante.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe escojer el representante de la empresa !", tsbBuscarTercero);
                return false;
            }
            else
            {
                return true;
            }*/

            return false;
        }
        private void asignarDatosEmpresa()
        {
            empresa.nit = txtNit.Text;
            empresa.razonSocial = txtNombre.Text;
            empresa.ubicacion = int.Parse(cmbCiudad.SelectedValue.ToString());
            empresa.direccion = txtDireccion.Text;
            empresa.telefono = txtTelefono.Text;
            empresa.celular = txtCelular.Text;
            empresa.email = txtMail.Text;
            empresa.encabezado = txtEncabezado.Text;
            empresa.pie = txtPie.Text;
            if (picLogo.Image != null)
            {
                using (Bitmap bmp = new Bitmap(picLogo.Image))
                {
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        bmp.Save(memStream, picLogo.Image.RawFormat);
                        empresa.logo = memStream.GetBuffer();
                    }
                }
            }

        }
        void limpiarObjetoEmpresa()
        {
            empresa.idEmpresa = 0;
            empresa.nit = string.Empty;
            empresa.razonSocial = string.Empty;
            empresa.codigoHabilitacion = string.Empty;
            empresa.ubicacion = 0;
            empresa.direccion = string.Empty;
            empresa.telefono = string.Empty;
            empresa.celular = string.Empty;
            empresa.email = string.Empty;
            empresa.sigla = string.Empty;
            empresa.encabezado = string.Empty;
            empresa.pie = string.Empty;
            empresa.logo = null;
            empresa.idResponsable = 0;
        }
        #endregion

    }
}
