using Entidad.Ingreso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Ingreso
{
    public partial class IngresoUI : Form
    {
        Atencion atencion = new Atencion();
        public IngresoUI()
        {
            InitializeComponent();
        }

        private void IngresoUI_Load(object sender, EventArgs e)
        {
            /*GeneralUI.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            establecerGridview();
            btnSalir.Enabled = true;
            GeneralUI.llenarCombo(Sentencias.ATENCION_CAUSA_EXTERNA + " " + Util.Constantes.ConstanteGeneral.CAUSA_EXTERNA + "",
                               Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                               cbCausaExterna);
            GeneralUI.llenarCombo(Sentencias.ATENCION_INSTITUCION + " " + Util.Constantes.ConstanteGeneral.INSTITUCIÓN + "",
                               Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                               cbInstitucion);
            GeneralUI.llenarCombo(Sentencias.ATENCION_CAMA + " " + Util.Constantes.ConstanteGeneral.CAMA + "",
                               Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                               cbCama);
            GeneralUI.llenarCombo(Sentencias.GENERAL_ENTORNO_ATENCION,
                              Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                              Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                              cbEntorno);
            GeneralUI.llenarCombo(Sentencias.GENERAL_AREA_ATENCION,
                             Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                             cbArea);
            GeneralUI.llenarCombo(Sentencias.ATENCION_VIA_INGRESO + " " + Util.Constantes.ConstanteGeneral.VIA_INGRESO + "",
                             Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                             cbVia);*/
        }

        public void establecerGridview()
        {
            /*atencion.establecerDt();
            dgvDiagnostico.Columns["dgId"].DataPropertyName = "Id";
            dgvDiagnostico.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvDiagnostico.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvDiagnostico.Columns["dgAgregar"].DataPropertyName = "Agregar";
            dgvDiagnostico.Columns["dgQuitar"].DataPropertyName = "Quitar";

            dgvDiagnostico.DataSource = atencion.dtDiagnostico;*/
        }

        private void btPacienteAdmision_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> parametros = new List<string>();

                GeneralUI.buscarDevuelveFila(Sentencias.ATENCION_BUSCAR_PACIENTE_ADMISIONADO,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarPaciente),
                                                   Mensajes.BUSQUEDA_PACIENTE, true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        public void cargarPaciente(DataRow filas)
        {
            txtIdAdmision.Text = Convert.ToString(filas.Field<int>("admision"));
            txtnombrePaciente.Text = filas.Field<String>("paciente");
            txtFechaAdmision.Text = Convert.ToString(filas.Field<DateTime>("fecha admision"));
            atencion.idAdmision = filas.Field<int>("admision");
            habilitarControles();
        }

        public void habilitarControles()
        {
            cbVia.Enabled = true;
            cbCausaExterna.Enabled = true;
            cbInstitucion.Enabled = true;
            cbEntorno.Enabled = true;
            cbCama.Enabled = true;
            cbArea.Enabled = true;
            Textautorizacion.Enabled = true;
            Textautorizacion.ReadOnly = false;
            txtIdAdmision.Enabled = true;
            txtnombrePaciente.Enabled = true;
            txtFechaAdmision.Enabled = true;
            txtIdAdmision.ReadOnly = true;
            txtFechaAdmision.ReadOnly = true;
            txtnombrePaciente.ReadOnly = true;
            fechaIngreso.Enabled = true;
        }

        private void dgvDiagnostico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void cargarDiagnostico(DataRow filas)
        {
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgId"].Value = filas.Field<int>("Id");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripcion");
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            habilitarNuevo();
        }

        public void habilitarNuevo()
        {
            /*btPacienteAdmision.Enabled = true;
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbBuscar.Enabled = false;
            dgvDiagnostico.Enabled = true;
            GeneralUI.limpiarControles(this);
            atencion.dtDiagnostico.Rows.Add();*/
           
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            btnSalir.Enabled = true;
            
        }

        public void limpiarContrles()
        {
            txtIdAdmision.Clear();
        }

        public bool validarForm()
            
        {
            /*dgvDiagnostico.EndEdit();
            atencion.dtDiagnostico.AcceptChanges();
            if (txtIdAdmision.Text.Equals(String.Empty))
            {
                MessageBox.Show("¡ Por favor cargue un paciente  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btPacienteAdmision.Focus();
                return false;
            }else if (cbVia.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Por favor seleccione la via de ingreso !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbVia.Focus();
                return false;
            }else if(cbCausaExterna.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Por favor seleccione una causa externa  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbCausaExterna.Focus();
                return false;
            }else if (cbInstitucion.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Por favor seleccione la institucion  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbInstitucion.Focus();
                return false;
            }else if (cbArea.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Por favor seleccione el area  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbArea.Focus();
                return false;
            }else if (cbEntorno.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Por favor seleccione el entorno  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbEntorno.Focus();
                return false;
            }else if (cbCama.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Por favor seleccione la cama  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbCama.Focus();
                return false;
            }else if(dgvDiagnostico.RowCount == 1)
            {
                MessageBox.Show("¡ Por favor debe seleccionar los diagnostico!", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDiagnostico.Focus();
                return false;
            }*/
            return true;
        }

        public void asignarDatos()
        {
            /*atencion.idEstadoAtencion = ConstanteGeneral.ESTADO_INICIADO;
            atencion.idAdmision = Convert.ToInt16( txtIdAdmision.Text);
            atencion.idArea = (String) cbArea.SelectedValue;
            atencion.idCama = (String)cbCama.SelectedValue;
            atencion.idCausaExterna = (String)cbCausaExterna.SelectedValue;
            atencion.idEntorno = (String)cbEntorno.SelectedValue;
            atencion.idInstitucion = (String)cbInstitucion.SelectedValue;
            atencion.idViaIngreso = (String)cbVia.SelectedValue;
            atencion.fechaIngreso = fechaIngreso.Value;
            atencion.numeroAutorizacion = Textautorizacion.Text.Equals(string.Empty) ? 0 : Convert.ToInt16( Textautorizacion.Text);*/
        }
        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    atencion.guardar();
                    GeneralUI.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    atencion.dtDiagnostico.Rows.RemoveAt(atencion.dtDiagnostico.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {

        }
        public void cargarDatos(DataRow filas)
        {
           
            /*atencion.idAtencion = filas.Field<int>("atencion");
            atencion.idAdmision = filas.Field<int>("Admision");
            atencion.cargarDatos();
            cbVia.SelectedValue = atencion.idViaIngreso;
            cbCausaExterna.SelectedValue = atencion.idCausaExterna;
            cbInstitucion.SelectedValue = atencion.idInstitucion;
            cbCama.SelectedValue = atencion.idCama;
            cbEntorno.SelectedValue = atencion.idEntorno;
            cbArea.SelectedValue = atencion.idArea;
            fechaIngreso.Value = atencion.fechaIngreso;
            Textautorizacion.Text = (Convert.ToString( atencion.numeroAutorizacion)); 
            txtIdAdmision.Text = Convert.ToString( atencion.idAdmision);
            txtnombrePaciente.Text = atencion.nombrePaciente;
            txtFechaAdmision.Text = Convert.ToString( atencion.fechaAdmision);
            dgvDiagnostico.DataSource = atencion.dtDiagnostico;
            tstModificar.Enabled = true;
            tsbAnular.Enabled = true;*/
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
           /* if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }*/
        }

        private void tsbAnular_Click_1(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    atencion.anular();
                    GeneralUI.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                    btnSalir.Enabled = true;
                    
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }

            }*/
        }

        private void tstModificar_Click_1(object sender, EventArgs e)
        {
            if (GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar))
            {
                atencion.dtDiagnostico.Rows.Add();
                btPacienteAdmision.Enabled = false;
                fechaIngreso.Enabled = false;
            }
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    atencion.guardar();
                    GeneralUI.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    atencion.dtDiagnostico.Rows.RemoveAt(atencion.dtDiagnostico.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void tsbNuevo_Click_2(object sender, EventArgs e)
        {
            habilitarNuevo();
            tstModificar.Enabled = false;
            tsbAnular.Enabled = false;
            
        }

        private void tstModificar_Click_2(object sender, EventArgs e)
        {
            if (GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar))
            {
                atencion.dtDiagnostico.Rows.Add();
                btPacienteAdmision.Enabled = false;
                fechaIngreso.Enabled = false;
            }
        }

        private void tsbCancelar_Click_1(object sender, EventArgs e)
        {
            GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            btnSalir.Enabled = true;
           
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    atencion.guardar();
                    GeneralUI.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    atencion.dtDiagnostico.Rows.RemoveAt(atencion.dtDiagnostico.Rows.Count - 1);
                    btnSalir.Enabled = true;
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void tsbBuscar_Click_1(object sender, EventArgs e)
        {

            /*try
            {
                List<string> parametros = new List<string>();

                GeneralUI.buscarDevuelveFila(Sentencias.ATENCION_BUSCAR,
                                                   parametros,
                                                   new GeneralUI.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSQUEDA_PACIENTE, true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }

        private void tsbAnular_Click_2(object sender, EventArgs e)
        {
            /*if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    atencion.anular();
                    GeneralUI.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                    btnSalir.Enabled = true;
                   
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }

            }*/
        }
        public void quitarFila()
        {
            dgvDiagnostico.Rows.RemoveAt(dgvDiagnostico.CurrentCell.RowIndex);
        }
        public void verificarFila()
        {
            if (string.IsNullOrEmpty(dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()))
            {
                dgvDiagnostico.Rows.RemoveAt(dgvDiagnostico.CurrentCell.RowIndex);
            }
        }
        public void buscarDiagnostico()
        {
            List<string> parametros = new List<string>();
            DataTable tablaParametros = new DataTable();
            DataTable tablasSeleccionado = new DataTable();

            tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
            tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

            DataView view = new DataView(atencion.dtDiagnostico);

            tablasSeleccionado = view.ToTable(true, new string[] { "id" }).Copy();
            tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
            object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

            tablaParametros.Rows.Add(myObjArray2);

            /*GeneralUI.buscarDevuelveFila(Sentencias.GENERAL_BUSCAR_DIAGNOSTICO,
                                               parametros,
                                               new GeneralUI.cargarInfoFila(cargarDiagnostico),
                                               Mensajes.BUSQUEDA_PACIENTE, true, null, tablasSeleccionado, tablaParametros);*/
        }

        private void dgvDiagnostico_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgAgregar"].Selected == true ||
              dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true)
            {
                try
                {
                    GeneralUI.agregarRegistroDatagridView(buscarDiagnostico, verificarFila, quitarFila, dgvDiagnostico, dgvDiagnostico.Columns["dgcodigo"].Index);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }
    }
}
