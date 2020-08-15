using Entidad.HistoriaClinica.Resultado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    public partial class HemodialisisUI : Form
    {
        Hemodialisis hemodialisis;
        private bool edicion = false;

        public HemodialisisUI()
        {
            InitializeComponent();
        }

        private void HemodialisisUI_Load(object sender, EventArgs e)
        {
            hemodialisis = new Hemodialisis();
            GeneralUI.deshabilitarBotones(ref tstMenuPatron);
            GeneralUI.deshabilitarControles(this);
            enlazarDgvMedicamento();
            tsbBuscar.Enabled = true;
            tsbNuevo.Enabled = true;
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

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaAnular())
            {
                try
                {

                    if (HemodialisisDAL.anularHemodialisis(hemodialisis.idHemodialisis,hemodialisis.auditoria))
                    {
                        GeneralC.deshabilitarBotones(ref tstMenuPatron);
                        GeneralC.limpiarControles(this);
                        GeneralC.deshabilitarControles(this);

                        btnSalir.Enabled = true;
                        tsbBuscar.Enabled = true;
                        tsbNuevo.Enabled = true;

                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_ANULADO);
                    }

                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();
            parametro.Add(hemodialisis.auditoria.ToString());
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_HEMODIALISIS,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarHemodialisis),
                                    Titulos.TITULO_BUSCAR_HEMODIALISIS,
                                    true,
                                    listaParametroOculto());*/
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            /*if (Mensajes.preguntaSiNo(Mensajes.CANCELAR_FORM)==true)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);

                hemodialisis.idHemodialisis = ConstanteGeneral.PREDETERMINADO;

                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }*/
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarCampos() == true)
            {
                if (Mensajes.preguntaGuardar())
                    try
                    {
                        crearNuevaHemodialisis();

                        HemodialisisDAL.guardarHemodialisis(hemodialisis);

                        GeneralUI.habilitarBotones(ref tstMenuPatron);
                        GeneralUI.deshabilitarControles(this);
                        cargarHemodialisisMedicamento();

                        btnSalir.Enabled = true;
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;

                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);
                    }
                    catch (Exception ex)
                    {
                        Mensajes.mensajeError(ex);
                    }
            }*/
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.Modificar_FORM)==true)
            {
                GeneralUI.deshabilitarBotones(ref tstMenuPatron);
                GeneralUI.habilitarControles(this);
                GeneralUI.deshabilitarControles(pnlInformacion);

                dtpFecha.Enabled = true;
                hemodialisis.dtMedicamento.Rows.Add();

                edicion = true;
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;

            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            /*GeneralUI.deshabilitarBotones(ref tstMenuPatron);
            GeneralUI.habilitarControles(this);

            GeneralUI.deshabilitarControles(pnlInformacion);
            GeneralUI.limpiarControles(this);

            hemodialisis.idHemodialisis=ConstanteGeneral.PREDETERMINADO;
            dtpFecha.Enabled = true;
            tsbBuscarNit.Enabled = true;
            hemodialisis.dtMedicamento.Rows.Add();

            edicion = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;*/

        }

        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            /*List<string> parametro = new List<string>();

            parametro.Add(hemodialisis.auditoria.ToString());
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_PACIENTE_HEMODIALISIS,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformacionAtencion),
                                    Titulos.TITULO_BUSCAR_PACIENTE,
                                    true,
                                    listaParametroOculto());*/
        }

        private void cargarInformacionAtencion(DataRow dRows) {
            txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
            txtPaciente.Text = dRows.Field<string>("paciente").ToString();
            txtIdentificacion.Text = dRows.Field<string>("Documento").ToString();
            txtServicio.Text = dRows.Field<string>("Entorno").ToString();
            txtOrdenMedica.Text = dRows.Field<int>("IdOrdenMedica").ToString();
            txtProcedimiento.Text = dRows.Field<string>("procedimiento").ToString();
            txtCodigoAdministradora.Text = dRows.Field<int>("IdContrato").ToString();
            txtAdministradora.Text = dRows.Field<string>("Nombre").ToString();
            dtFechaIngreso.Value = dRows.Field<DateTime>("FechaAdmision");
            hemodialisis.idOrdenMedica = dRows.Field<int>("IdOrdenMedica");
            hemodialisis.idProcedimiento= dRows.Field<int>("IdProcedimiento"); 

        }

        private void crearNuevaHemodialisis() {
            hemodialisis.nota = txtNota.Text;
            hemodialisis.fecha = dtpFecha.Value;
            hemodialisis.notaSigno = string.IsNullOrEmpty(txtNotaSigno.Text) ? null : txtNotaSigno.Text;
        }
        private void cargarHemodialisis(DataRow dRows)
        {
                hemodialisis.idHemodialisis = dRows.Field<int>("idHemodialisis");
                dtpFecha.Value = dRows.Field<DateTime>("Fecha Resultado");
                txtNota.Text = dRows.Field<string>("Nota").ToString();
                txtNotaSigno.Text = dRows.Field<string>("SignosVitales").ToString();
                cargarInformacionAtencion(dRows);
                cargarHemodialisisMedicamento();
            GeneralUI.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular,tstImprimir);
            btnSalir.Enabled = true;
        }
        private List<string> listaParametroOculto()
        {
            /*List<string> paramtro = new List<string>();

            paramtro.Add("idAtencion");
            paramtro.Add("IdOrdenMedica");
            paramtro.Add("IdContrato");
            paramtro.Add("Nombre");
            paramtro.Add("FechaAdmision");
            paramtro.Add("IdProcedimiento");

            if (hemodialisis.idHemodialisis != ConstanteGeneral.PREDETERMINADO)
            {
                paramtro.Add("idHemodialisis");
                paramtro.Add("FechaAdmision");
                paramtro.Add("Nota");
                paramtro.Add("SignosVitales");
            }

            return paramtro;*/
            return null;
        }
        private Boolean validarCampos()
        {
            if (txtAtencion.Text == string.Empty)
            {
                MessageBox.Show("¡ Favor seleccionar el paciente !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNota.Text == string.Empty)
            {
                MessageBox.Show("¡ Favor realice la nota correspondiente al resultado !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }
        #region tabMedicamento
        public void enlazarDgvMedicamento()
        {
            dgvMedicamento.AutoGenerateColumns = false;
            dgvMedicamento.Columns["codigoMed"].DataPropertyName = "idMedicamento";
            dgvMedicamento.Columns["descripcionMed"].DataPropertyName = "descripcion";
            dgvMedicamento.Columns["cantidadMed"].DataPropertyName = "cantidad";
            dgvMedicamento.DataSource = hemodialisis.dtMedicamento;
        }
        void cargarMedicamento(DataRow filaResultado)
        {
            DataRowCollection filas = hemodialisis.dtMedicamento.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idMedicamento"] = filaResultado.Field<int>("Codigo");
            filas[cantidad]["descripcion"] = filaResultado.Field<string>("Descripcion");
            filas[cantidad]["cantidad"] = 1;
            filas.Add();
        }
        private void cargarHemodialisisMedicamento() {
           /* List<string> paramtro = new List<string>();
            paramtro.Add(hemodialisis.auditoria.ToString());
            paramtro.Add(hemodialisis.idHemodialisis.ToString());
            hemodialisis.dtMedicamento = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_HEMODIALISIS_MEDICAMENTO, paramtro);
            dgvMedicamento.DataSource = hemodialisis.dtMedicamento;*/
        }
        private void dgvMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (txtAtencion.Text != string.Empty)
            {
                if (e.RowIndex >= 0)
                {
                    GeneralC.deshabilitarColumnas(dgvMedicamento);
                    if (edicion)
                    {
                        dgvMedicamento.Columns["cantidadMed"].ReadOnly = false;
                        if (GeneralC.verificarUbicacionCelda(e, dgvMedicamento, "quitarMed") & e.RowIndex < dgvMedicamento.Rows.Count - 1)
                        {
                            if (Mensajes.preguntaAnular())
                            {
                                hemodialisis.dtMedicamento.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                        else if (GeneralC.verificarUbicacionCelda(e, dgvMedicamento, "agregarMed") & e.RowIndex == dgvMedicamento.Rows.Count - 1)
                        {
                            try
                            {
                                List<string> parametros = new List<string>();

                                DataTable tablaParametros = new DataTable();
                                DataTable tablasSeleccionado = new DataTable();

                                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                                object[] myObjArray1 = { "@pFiltro", "" };

                                DataView view = new DataView(hemodialisis.dtMedicamento);

                                tablasSeleccionado = view.ToTable(true, new string[] { "idMedicamento" }).Copy();
                                tablasSeleccionado.Columns.Add("valor");
                                tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                                object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

                                tablaParametros.Rows.Add(myObjArray1);
                                tablaParametros.Rows.Add(myObjArray2);

                                GeneralC.buscarDevuelveFila(Sentencias.LISTAR_MEDICAMENTOS,
                                                            parametros,
                                                            new GeneralC.cargarInfoFila(cargarMedicamento),
                                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                                            true,
                                                            null,
                                                            tablasSeleccionado,
                                                            tablaParametros);
                            }
                            catch (Exception ex)
                            {
                                Mensajes.mensajeError(ex);
                            }
                        }
                    }
                }
            }
            else
            {
                Mensajes.mensajeAdvertencia("Favor Cargar los datos del paciente");
            }*/
        }
        private void dgvMedicamento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvMedicamento.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }
        private void dgvMedicamento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dgvMedicamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvMedicamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }
        }
        #endregion
    }
}
