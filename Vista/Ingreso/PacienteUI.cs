using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidad.Ingreso;
using Vista.General;

namespace Vista.Ingreso
{
    public partial class PacienteUI : Form
    {
        Paciente paciente = new Paciente();
        public PacienteUI()
        {
            InitializeComponent();
        }
        private void PacienteUI_Load(object sender, EventArgs e)
        {
            GeneralUI.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            inicio();
            btnSalir.Enabled = true;
        }
        private void inicio()
        {
            establecerParametros();
            //GeneralUI.llenarCombo(Sentencias.CARGAR_PAIS,ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER,cmbPaisDocumento);
            //GeneralUI.llenarCombo(Sentencias.CARGAR_PAIS,ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER,cmbPaisNacimiento);
            //GeneralUI.llenarCombo(Sentencias.CARGAR_PAIS,ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER, cmbPaisResidencia);*/
        }

        public void establecerParametros()
        {
           /* paciente.establecerColumnas();
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.AFILIACION);
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.ZONA);
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.REGIMEN);
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.CLASESOCIAL);
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.ESTADOCIVIL);
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.DOCUMENTOS);
            paciente.dtParametro.Rows.Add(ConstanteGeneral.PARAMETRO_PACIENTE.GENERO);
            paciente.cargarParametros();*/
        }
        private void departNacBox_SelectedValueChanged(object sender, EventArgs e)
        {
            /*if (cmbDepartamentoNac.SelectedIndex > 0 && tsbGuardar.Enabled == true)
            {
                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + cmbDepartamentoNac.SelectedValue + "",ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER,cmbCiudadNacimiento);
                GeneralUI.validarComboUbicacion(cmbDepartamentoNac, cmbCiudadNacimiento);
            }*/
        }

        public bool validarForm()
        {
            if(cmbDocumento.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione un tipo de documento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDocumento.Focus();
                return false;
            }else if (txtIdentificacion.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el numero del documento identidad !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdentificacion.Focus();
                return false;
            }else if (cmbPaisDocumento.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el pais de expedición !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPaisDocumento.Focus();
                return false;
            }else if (cmbDepartamentoDoc.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el departamento de expedición !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDepartamentoDoc.Focus();
                return false;
            }else if (cmbCiudadDocumento.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el municipio de expedición !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCiudadDocumento.Focus();
                return false;
            }else if (txtPrimerNombre.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el primer nombre !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrimerNombre.Focus();
                return false;
            }else if (txtPrimerApellido.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el primer apellido !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrimerApellido.Focus();
                return false;
            }else if (txtSegundoApellido.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el segundo apellido !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSegundoApellido.Focus();
                return false;
            }else if (cmbSexo.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el genero !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSexo.Focus();
                return false;
            }else if (txtEPS.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor seleccione la EPS !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEPS.Focus();
                return false;
             
            }else if (txtEdad.Equals(string.Empty))
            {
                MessageBox.Show("¡ Por favor seleccionar la edad del paciente !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpNacimiento.Focus();
                return false;
            }
            else if (cmbPaisNacimiento.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el pais de nacimiento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPaisNacimiento.Focus();
                return false;
            }else if (cmbDepartamentoNac.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el departamento de nacimiento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDepartamentoNac.Focus();
                return false;
            }else if (cmbCiudadNacimiento.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el municipio de nacimiento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCiudadNacimiento.Focus();
                return false;
            }else if (cmbRegimen.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el regimen !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbRegimen.Focus();
                return false;
            }else if (cmbAfiliacion.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el tipo de afiliación !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbAfiliacion.Focus();
                return false;
            }else if (cmbEstrato.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el estrato social !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbEstrato.Focus();
                return false;
            }else if (cmbZona.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione la zona !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbZona.Focus();
                return false;
            }else if (cmbEstadoCivil.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el estado civil !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbEstadoCivil.Focus();
                return false;
            }else if (cmbPaisResidencia.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el pais de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPaisResidencia.Focus();
                return false;
            }else if (cmbDepartamentoRes.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el departamento de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDepartamentoRes.Focus();
                return false;
            }else if (cmbCiudadResidencia.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el municipio de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCiudadResidencia.Focus();
                return false;
            }else if (txtDireccion.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite la direccion de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDireccion.Focus();
                return false;
            }else if (txtTelefono.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el numero de telefono !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Focus();
                return false;
            }
            else
            {
                return true;
            }        
        }

        void asignarDatos()
        {
            paciente.primeroNombre = txtPrimerNombre.Text;
            paciente.segundoNombre = txtSegundoNombre.Text;
            paciente.primerApellido = txtPrimerApellido.Text;
            paciente.segundoApellido = txtSegundoApellido.Text;
            paciente.tipoIdentificacion = Convert.ToString( cmbDocumento.SelectedValue);
            paciente.documentoIndentidad = txtIdentificacion.Text;
            paciente.idMunicipioExpedicion = Convert.ToString( cmbCiudadDocumento.SelectedValue);
            paciente.idMunicipioNacimiento = Convert.ToString( cmbCiudadNacimiento.SelectedValue);
            paciente.idMunicipioResidencia = Convert.ToString( cmbCiudadResidencia.SelectedValue);
            paciente.correo = txtEmail.Text;
            paciente.idGenero = Convert.ToString( cmbSexo.SelectedValue);
            paciente.direccionResidencia = txtDireccion.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.celular = txtCelular.Text;
            paciente.fechaNacimiento = dtpNacimiento.Value;
            paciente.idRegimen = Convert.ToString( cmbRegimen.SelectedValue);
            paciente.idTipoAfiliacion = Convert.ToString( cmbAfiliacion.SelectedValue);
            paciente.idZonaUrbana = Convert.ToString( cmbZona.SelectedValue);
            paciente.idEstadoCivil = Convert.ToString( cmbEstadoCivil.SelectedValue);
            paciente.idestrato = Convert.ToString( cmbEstrato.SelectedValue);
        }
        public void cargarRegistro(DataRow fila)
        {
            paciente.idEps = fila.Field<int>("idEps");
            txtEPS.Text = fila.Field<string>("Descripcion");
        }
        public void cargarPaciente(DataRow fila)
        {
            /*paciente.idPaciente = fila.Field<int>("idPaciente");
            txtEPS.Text = fila.Field<string>("eps");
            paciente.cargarUbicaciones();
            paciente.cargarDatos();
            cmbDocumento.SelectedValue = paciente.tipoIdentificacion;
            txtIdentificacion.Text = Convert.ToString(paciente.documentoIndentidad);
            GeneralUI.cargarUbicacionGeografica(paciente.dtUbicacion, paciente.idMunicipioExpedicion, ref cmbPaisDocumento, ref cmbDepartamentoDoc, ref cmbCiudadDocumento);
            GeneralUI.cargarUbicacionGeografica(paciente.dtUbicacion, paciente.idMunicipioNacimiento, ref cmbPaisNacimiento, ref cmbDepartamentoNac, ref cmbCiudadNacimiento);
            GeneralUI.cargarUbicacionGeografica(paciente.dtUbicacion, paciente.idMunicipioResidencia, ref cmbPaisResidencia, ref cmbDepartamentoRes, ref cmbCiudadResidencia);
            txtPrimerNombre.Text = paciente.primeroNombre;
            txtSegundoNombre.Text = paciente.segundoNombre;
            txtPrimerApellido.Text = paciente.primerApellido;
            txtSegundoApellido.Text = paciente.segundoApellido;
            cmbSexo.SelectedValue = paciente.idGenero;
            cmbEstrato.SelectedValue = paciente.idestrato;
            cmbZona.SelectedValue = paciente.idZonaUrbana;
            cmbRegimen.SelectedValue = paciente.idRegimen;
            cmbAfiliacion.SelectedValue = paciente.idTipoAfiliacion;
            cmbEstadoCivil.SelectedValue = paciente.idEstadoCivil;
            txtDireccion.Text = paciente.direccionResidencia;
            txtTelefono.Text = paciente.telefono;
            txtCelular.Text = paciente.celular;
            txtEmail.Text = paciente.correo;
            dtpNacimiento.Value = paciente.fechaNacimiento;
            GeneralUI.calcularEdad(dtpNacimiento, ref edad);
            txtEdad.Text = edad;
            tstModificar.Enabled = true;
            tsbAnular.Enabled = true;
            btnSalir.Enabled = true;*/
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            /*GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            paciente.idPaciente = 0;
            dtpNacimiento.ResetText();*/
        }

        private void paisBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbPaisDocumento.SelectedIndex > 0 && tsbGuardar.Enabled == true)
            {

              GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + cmbPaisDocumento.SelectedValue + "",ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER,cmbDepartamentoDoc);
              GeneralUI.validarComboUbicacion(cmbPaisDocumento, cmbDepartamentoDoc);
            }*/
        }

        private void departBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
           /* if (cmbDepartamentoDoc.SelectedIndex > 0 && tsbGuardar.Enabled == true)
            {

              GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + cmbDepartamentoDoc.SelectedValue + "",ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER,cmbCiudadDocumento);
              GeneralUI.validarComboUbicacion(cmbDepartamentoDoc, cmbCiudadDocumento);
            }*/
        }

        private void paisNacBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbPaisNacimiento.SelectedIndex > 0 && tsbGuardar.Enabled ==  true)
            {
              GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + cmbPaisNacimiento.SelectedValue + "",ConstanteGeneral.VALUE_MEMBER,ConstanteGeneral.DISPLAY_MEMBER,cmbDepartamentoNac);
              GeneralUI.validarComboUbicacion(cmbPaisNacimiento, cmbDepartamentoNac);
            }*/
        }
        private void departNacBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbDepartamentoNac.SelectedIndex > 0 && tsbGuardar.Enabled == true)
            {
                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + cmbDepartamentoNac.SelectedValue + "",
                                 ConstanteGeneral.VALUE_MEMBER,
                                 ConstanteGeneral.DISPLAY_MEMBER,
                                 cmbCiudadNacimiento);
                GeneralUI.validarComboUbicacion(cmbDepartamentoNac, cmbCiudadNacimiento);
            }*/
        }

        private void paisResBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbPaisResidencia.SelectedIndex > 0 && tsbGuardar.Enabled == true)
            {
                GeneralUI.llenarCombo(Sentencias.CARGAR_DEPARTAMENTO + " " + cmbPaisResidencia.SelectedValue + "",
                                 ConstanteGeneral.VALUE_MEMBER,
                                 ConstanteGeneral.DISPLAY_MEMBER,
                                 cmbDepartamentoRes);
                GeneralUI.validarComboUbicacion(cmbPaisResidencia, cmbDepartamentoRes);
            }*/
        }
        private void departResBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            /*if (cmbDepartamentoRes.SelectedIndex > 0 && tsbGuardar.Enabled ==  true)
            {
                GeneralUI.llenarCombo(Sentencias.CARGAR_MUNICIPIO + " " + cmbDepartamentoRes.SelectedValue + "",
                                 ConstanteGeneral.VALUE_MEMBER,
                                 ConstanteGeneral.DISPLAY_MEMBER,
                                 cmbCiudadResidencia);
                GeneralUI.validarComboUbicacion(cmbDepartamentoRes, cmbCiudadResidencia);
            }*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
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

        private void buscarEpsBtn_Click_2(object sender, EventArgs e)
        {

                List<string> parametros = new List<string>();

                /*GeneralUI.buscarDevuelveFila(Sentencias.CARGAR_EPS,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true);*/
   
           
        }
        private void fechaNPicker_Validating(object sender, CancelEventArgs e)
        {

            /*GeneralUI.calcularEdad(dtpNacimiento, ref edad);
            txtEdad.Text = edad;*/
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            /*GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            paciente.idPaciente = 0;*/
        }
        private void tsbGuardar_Click_2(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    /*asignarDatos();
                    PacienteDAL.guardar(paciente);
                    GeneralUI.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);*/
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            paciente.idPaciente = 0;
            btnSalir.Enabled = true;
            dtpNacimiento.ResetText();*/
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            //GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }

        private void tsbBuscar_Click_2(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();

                GeneralUI.buscarDevuelveFila(Sentencias.PACIENTE_BUSCAR,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarPaciente),
                                                   Mensajes.BUSQUEDA_PACIENTE, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void tsbAnular_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*paciente.eliminar();
                    GeneralUI.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                    btnSalir.Enabled = true;*/         
            }
        }
    }
}
