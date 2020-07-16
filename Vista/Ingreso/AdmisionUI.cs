using Entidad.Ingreso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Ingreso
{
    public partial class AdmisionUI : Form
    {
        Admision admision = new Admision();
        public AdmisionUI()
        {
            InitializeComponent();
        }

        /*public void cargarRegistro(DataRow fila)
        {
            admision.idPaciente = fila.Field<int>("IdPaciente");
            admision.cargarPaciente();
            txtAfiliacion.Text = admision.tipoAfiliacion;
            txtHClinica.Text = admision.identificacion;
            txtEstratoSocial.Text = admision.estratoSocial;
            txtRegimen.Text = admision.regimen;
            txtPaciente.Text = admision.nombrePaciente;
            txtEPS.Text = admision.nombreEPS;
        }

        */private void AdmisionUI_Load(object sender, EventArgs e)
        {
            /*establecerParametros();
            GeneralUI.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            GeneralUI.llenarCombo(Sentencias.CARGAR_PAIS,
                               Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                               cmbResponsablePais);
            GeneralUI.llenarCombo(Sentencias.CARGAR_PAIS,
                               Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                               cmbAcompanantePais);
            GeneralUI.llenarCombo(Sentencias.ADMISION_TRIAGE +" "+ Util.Constantes.ConstanteGeneral.TRIAGE + "",
                              Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                              Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                              cmbTriage);
            cargarCombosDatatable(admision.dtResultado, (int)ConstanteGeneral.PARAMETRO_PACIENTE.DOCUMENTOS, cmbTipoDocumento);
            cargarCombosDatatable(admision.dtResultado, (int)ConstanteGeneral.PARAMETRO_PACIENTE.DOCUMENTOS, cmbTipoDocumentoResponsable);
            btnSalir.Enabled = true;*/
        }
        /*public void establecerParametros()
        {
            admision.establecerColumnas();
            admision.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.DOCUMENTOS);
            admision.cargarParametros();
        }
        public void cargarCombosDatatable(DataTable dt, Int32 idParametro, ComboBox combo)
        {
            DataTable dtC = new DataTable();
            DataRow[] filas;
            dtC = dt.Clone();
            filas = dt.Select("idParametro=" + idParametro);
            foreach (DataRow fila in filas)
            {
                dtC.ImportRow(fila);
            }
            dtC.Columns.Remove("idParametro");
            GeneralUI.llenarComboDatosDefinidor(dtC, ConstanteGeneral.VALUE_MEMBER, ConstanteGeneral.DISPLAY_MEMBER, combo);
        }
        #region zonaGeografica

       

       

       
           
                #endregion

        */private void buscarHCPacienteBtn_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();

                GeneralUI.buscarDevuelveFila(Sentencias.ADMISION_PACIENTE_BUSCAR,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void paisAcompañante_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbAcompanantePais.SelectedIndex > 0)
            {

                GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + cmbAcompanantePais.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                    cmbAcompananteDpto);
                GeneralUI.validarComboUbicacion(cmbAcompanantePais, cmbAcompananteDpto);
            }
            else
            {

                GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                   cmbAcompananteDpto);
                GeneralUI.validarComboUbicacion(cmbAcompanantePais, cmbAcompananteDpto);
            }*/
        }

        private void departAcompañanteBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
           /* if (cmbAcompananteDpto.SelectedIndex > 0)
            {

                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + cmbAcompananteDpto.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                    cmbAcompananteCiudad);
                GeneralUI.validarComboUbicacion(cmbAcompananteDpto, cmbAcompananteCiudad);
            }
            else
            {
                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                   cmbAcompananteCiudad);
                GeneralUI.validarComboUbicacion(cmbAcompananteDpto, cmbAcompananteCiudad);
            }*/
        }

        private void paisResponsableBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbResponsablePais.SelectedIndex > 0)
            {

                GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + cmbResponsablePais.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                    cmbResponsableDpto);
                GeneralUI.validarComboUbicacion(cmbResponsablePais, cmbResponsableDpto);
            }
            else
            {

                GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                   cmbResponsableDpto);
                GeneralUI.validarComboUbicacion(cmbResponsablePais, cmbResponsableDpto);
            }*/
        }

        private void departRespBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbResponsableDpto.SelectedIndex > 0)
            {

                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + cmbResponsableDpto.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                    cmbResponsableCiudad);
                GeneralUI.validarComboUbicacion(cmbResponsableDpto, cmbResponsableCiudad);
            }
            else
            {
                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                   cmbResponsableCiudad);
                GeneralUI.validarComboUbicacion(cmbResponsableDpto, cmbResponsableCiudad);
            }*/
        }

        private void buscarContratoOtrosBtn_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(admision.idEps));
                GeneralUI.buscarDevuelveFila(Sentencias.ADMISION_CONTRATO_EPS,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarContratoEps),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        public void cargarContratoEps(DataRow fila)
        {
            tctContrato.Text = Convert.ToString(fila.Field<int>("Código"));
            txtClienteContrato.Text = fila.Field<String>("Cliente");
            admision.idContrato = fila.Field<int>("Código");
        }

             
        private void buscarEspOtrosBtn_Click(object sender, EventArgs e)
        {
           /* try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(Util.Constantes.ConstanteGeneral.ESPECIALIDAD));
                GeneralUI.buscarDevuelveFila(Sentencias.ADMISION_ESPECIALIDAD,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarEspecialidad),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        public void cargarEspecialidad(DataRow filas)
        {
            txtEspecialidad.Text = filas.Field<String>("descripcion");
            admision.idEspecialidad = filas.Field<int>("Código");
        }

        /*public bool validarForm()
        {
            if (tctContrato.Text.Equals(String.Empty))
            {
                MessageBox.Show("¡ Favor seleccione el contrato  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btBuscarContrato.Focus();
                return false;

            }else if (cmbTriage.SelectedIndex ==0)
            {
                MessageBox.Show("¡ Favor seleccione el triage  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTriage.Focus();
                return false;
            }else if (txtEspecialidad.Text.Equals(String.Empty))
            {
                MessageBox.Show("¡ Favor seleccione la especialidad  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEspecialidad.Focus();
                return false;
            }else if (chkAcompanante.Checked)
            {
                if (cmbTipoDocumento.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el tipo de documento del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoDocumento.Focus();
                    return false;
                }else if (txtAcompananteIdentificacion.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el numero de documento del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAcompananteIdentificacion.Focus();
                    return false;
                }else if (txtAcompananteNombre.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el nombre completo del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAcompananteNombre.Focus();
                    return false;
                }else if (cmbAcompanantePais.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el pais del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbAcompanantePais.Focus();
                    return false;
                }else if (cmbAcompananteDpto.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el departamento del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbAcompananteDpto.Focus();
                    return false;
                }else if (cmbAcompananteCiudad.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el municipio del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbAcompananteCiudad.Focus();
                    return false;
                }else if (txtAcompananteDireccion.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite la direccion del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAcompananteDireccion.Focus();
                    return false;
                }
            else if (checkResponsable.Checked)
            {
                if (cmbTipoDocumentoResponsable.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el tipo de documento del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoDocumentoResponsable.Focus();
                    return false;
                }
                else if (txtResponsableIdentificacion.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el numero de documento del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtResponsableIdentificacion.Focus();
                    return false;
                }
                else if (txtResponsableNombre.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el nombre completo del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtResponsableNombre.Focus();
                    return false;
                }
                else if (cmbResponsablePais.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el pais del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbResponsablePais.Focus();
                    return false;
                }
                else if (cmbResponsableDpto.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el departamento del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbResponsableDpto.Focus();
                    return false;
                }
                else if (cmbResponsableCiudad.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el municipio del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbResponsableCiudad.Focus();
                    return false;
                }
                else if (txtResponsableDireccion.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite la direccion del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtResponsableDireccion.Focus();
                    return false;
                }
            }
            else
            {
                return true;
            }
            }
            return true;    
        }
        */private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    admision.guardar();
                    txtAtencion.Text = Convert.ToString(admision.idAdmision);
                    GeneralUI.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    btnSalir.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }

        /*public void asignarDatos()
        {
            admision.idAdmision = (txtAtencion.Text.Equals(String.Empty))  ? 0: int.Parse(txtAtencion.Text);
            admision.fecha = dtpAdmision.Value;
            admision.tipoDocumentoAcompañante = Convert.ToString( cmbTipoDocumento.SelectedValue);
            admision.tipoDocumentoResponsable = Convert.ToString(cmbTipoDocumentoResponsable.SelectedValue);
            admision.identificacionAcompañante = txtAcompananteIdentificacion.Text;
            admision.identificacionResponsable = txtResponsableIdentificacion.Text;
            admision.nombreAcompañante = txtAcompananteNombre.Text;
            admision.nombreResponsable = txtResponsableNombre.Text;
            admision.telefonoAcompañante = txtAcompananteTelefono.Text;
            admision.telefonoResponsable = txtResponsableTelefono.Text;
            admision.idMunicipioAcompañante = Convert.ToString(cmbAcompananteCiudad.SelectedValue);
            admision.idMunicipioResponsable = Convert.ToString(cmbResponsableCiudad.SelectedValue);
            admision.direccionAcompañante = txtAcompananteDireccion.Text;
            admision.direccionResponsable = txtResponsableDireccion.Text;
            admision.idTriage = Convert.ToString(cmbTriage.SelectedValue);
            admision.acompanante = chkAcompanante.Checked;
            admision.responsable = checkResponsable.Checked;
        }

        */private void checkAcompanante_CheckedChanged(object sender, EventArgs e)
        {
           /* if (chkAcompanante.Checked)
            {
                pnlAcompanante.Enabled = true;
            }else
            {
                pnlAcompanante.Enabled = false;
                GeneralUI.limpiarControles(pnlAcompanante);
            }*/
        }

       private void checkResponsable_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkResponsable.Checked)
            {
                pnlResponsable.Enabled = true;
            }else
            {
                pnlResponsable.Enabled = false;
                GeneralUI.limpiarControles(pnlResponsable);
            }*/
        }

        public void deshabilitarCombosUbicacion()
        {
            cmbAcompananteDpto.Enabled = false;
            cmbResponsableDpto.Enabled = false;
            cmbAcompananteCiudad.Enabled = false;
            cmbResponsableCiudad.Enabled = false;
        }

        private void deshabilitarControles() {
            txtAtencion.ReadOnly = true;
            txtHClinica.ReadOnly = true;
            txtPaciente.ReadOnly = true;
            txtRegimen.ReadOnly = true;
            txtEstratoSocial.ReadOnly = true;
            txtAfiliacion.ReadOnly = true;
            txtEPS.ReadOnly = true;
            txtClienteContrato.ReadOnly = true;
            tctContrato.ReadOnly = true;
            txtEspecialidad.ReadOnly = true;
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
           /* GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            buscarHCPacienteBtn.Enabled = false;
            dtpAdmision.Enabled = false;
            deshabilitarControles();*/


        }/*

        */private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            admision.idAdmision = ConstanteGeneral.PREDETERMINADO;
            btnSalir.Enabled = true;
            dtpAdmision.ResetText();*/
           

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            //admision.idAdmision = ConstanteGeneral.PREDETERMINADO;
            dtpAdmision.ResetText();
            //deshabilitarControles();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();

                GeneralUI.buscarDevuelveFila(Sentencias.ADMISION_BUSCAR,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        /*
        public void cargarDatos(DataRow filas)
        {
            admision.responsable = false;
            admision.acompanante = false;
            admision.idAdmision = filas.Field<int>("Admision");
            admision.cargarUbicaciones();
            admision.cargarDatos();
            tctContrato.Text = Convert.ToString( admision.idContrato);
            txtClienteContrato.Text = admision.cliente;
            cmbTriage.SelectedValue = admision.idTriage;
            txtEspecialidad.Text = admision.especialidad;
            txtAtencion.Text = Convert.ToString( admision.idAdmision);
            tstModificar.Enabled = true;
            tsbAnular.Enabled = true;
            if (admision.acompanante)
            {
                cmbTipoDocumento.SelectedValue = admision.tipoDocumentoAcompañante;
                txtAcompananteIdentificacion.Text = admision.identificacionAcompañante;
                txtAcompananteNombre.Text = admision.nombreAcompañante;
                GeneralUI.cargarUbicacionGeografica(admision.dtUbicacion, admision.idMunicipioAcompañante, ref cmbAcompanantePais, ref cmbAcompananteDpto, ref cmbAcompananteCiudad);
                txtAcompananteDireccion.Text = admision.direccionAcompañante;
                txtAcompananteTelefono.Text = admision.telefonoAcompañante;
                chkAcompanante.Checked = admision.acompanante;
            }
            else {
                GeneralUI.limpiarControles(pnlAcompanante);
                chkAcompanante.Checked = false;
            }

            if (admision.responsable)
            {
                cmbTipoDocumentoResponsable.SelectedValue = admision.tipoDocumentoResponsable;
                txtResponsableIdentificacion.Text = admision.identificacionResponsable;
                txtResponsableNombre.Text = admision.nombreResponsable;
                GeneralUI.cargarUbicacionGeografica(admision.dtUbicacion, admision.idMunicipioResponsable, ref cmbResponsablePais, ref cmbResponsableDpto, ref cmbResponsableCiudad);
                txtResponsableDireccion.Text = admision.direccionResponsable;
                txtResponsableTelefono.Text = admision.telefonoResponsable;
                checkResponsable.Checked = admision.responsable;
            }
            else {
                GeneralUI.limpiarControles(pnlResponsable);
                checkResponsable.Checked = false;
            }
            admision.cargarPaciente();
            txtAfiliacion.Text = admision.tipoAfiliacion;
            txtHClinica.Text = admision.identificacion;
            txtEstratoSocial.Text = admision.estratoSocial;
            txtRegimen.Text = admision.regimen;
            txtPaciente.Text = admision.nombrePaciente;
            txtEPS.Text = admision.nombreEPS;
            deshabilitarCombosUbicacion();
        }
        */
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*try
                {
                    admision.anular();
                    GeneralUI.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }*/

            }
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
