using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica
{
    public partial class SabanaEnfermeriaUI : Form

    {
        private int idAtencion;
        private bool auditoria;
        //private Sabana sabana = new Sabana();
        public SabanaEnfermeriaUI()
        {
            InitializeComponent();

        }
        public SabanaEnfermeriaUI(int idAtencion , bool auditoria, DateTime fechaIngreso, DateTime fechaEgreso) {
            InitializeComponent();
           /* this.idAtencion = idAtencion;
            this.auditoria = auditoria;
            sabana.auditoria = auditoria;
            sabana.idAtencion = idAtencion;
            dtpFecha.MinDate = fechaIngreso;
            dtpFecha.MaxDate = fechaEgreso;*/
        }

        private void SabanaEnfermeriaUI_Load(object sender, EventArgs e)
        {
            dtpFecha.Enabled = true;
            cargarSabanaDia();
            GeneralUI.deshabilitarColumnas(dgvSabanaMedicamentos);
            GeneralUI.deshabilitarColumnas(dgvSabanaGoteo);
        }
        private void cargarSabanaDia()
        {
            /*try
            {
                DataSet tablasResultados = new DataSet();
                List<string> Parametros = new List<string>();
                Parametros.Add(auditoria.ToString());
                Parametros.Add(idAtencion.ToString());
                Parametros.Add(dtpFecha.Value.Date.ToString("yyyy/MM/dd"));
                tablasResultados = GeneralC.llenarDataset(Sentencias.SABANA_CARGAR, Parametros);
                txtCodigoSabana.Clear();
                txtEstado.Clear();
                if ((int)tablasResultados.Tables["Table"].Rows.Count > 0)
                {
                    txtCodigoSabana.Text = Convert.ToString(tablasResultados.Tables["Table"].Rows[0].Field<int>("idSabana"));
                    txtEstado.Text = tablasResultados.Tables["Table"].Rows[0].Field<string>("CambiosPendiente");
                    sabana.idSabana = Convert.ToInt32(tablasResultados.Tables["Table"].Rows[0].Field<int>("idSabana"));
                }
                if (string.IsNullOrEmpty(txtCodigoSabana.Text))
                {
                    sabana.idSabana = ConsultasHistoriaClinica.NUEVO;
                }
                sabana.dtMedicamento = tablasResultados.Tables["Table1"];
                sabana.dtGoteo = tablasResultados.Tables["Table2"];
                dgvSabanaMedicamentos.DataSource = sabana.dtMedicamento;
                dgvSabanaGoteo.DataSource = sabana.dtGoteo;
                verificarTab();
            }
            catch(Exception ex)
            {
                Mensajes.mensajeError(ex); 
            }*/

            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //cargarSabanaDia();
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            /*modoEdicion(true);
            GeneralC.habilitarColumnas(dgvSabanaGoteo);
            dgvSabanaGoteo.Columns["descripcionGoteo"].ReadOnly = true; */
        }

        private void modoEdicion(bool edicion)
        {
            tsbCancelar.Enabled = edicion;
            tsbGuardar.Enabled = edicion;
            tstModificar.Enabled = !edicion;
            dtpFecha.Enabled = !edicion;
        }

        private void dgvSabanaGoteo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvSabanaGoteo.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            modoEdicion(false);
            GeneralUI.deshabilitarColumnas(dgvSabanaGoteo);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if ( Mensajes.preguntaGuardar())
            {
                dgvSabanaMedicamentos.EndEdit();
                sabana.dtMedicamento.AcceptChanges();
                dgvSabanaGoteo.EndEdit();
                sabana.dtGoteo.AcceptChanges();
                try
                {
                    sabana.prepararDT();
                    sabana.fecha = dtpFecha.Value.Date;
                    SabanaDAL.guardar(ref sabana);
                    verificarTab();
                    Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO); 
                    modoEdicion(false);
                    GeneralC.deshabilitarColumnas(dgvSabanaGoteo);
                    txtCodigoSabana .Text = Convert.ToString(sabana.idSabana);
                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }*/
            
        }
        private void pintarDGVMedicamentos()
        {
            dgvSabanaMedicamentos.DefaultCellStyle.Font = new Font("[FontFamily: Name=Arial Narrow]", 7);
            pintarCeldas(ref dgvSabanaMedicamentos);
            agregarOpcionAplicar();
            dgvSabanaMedicamentos.Columns["idMedicamento"].Visible = false;
        }
        private void agregarOpcionAplicar()
        {
            /*int fila;
            int indiceColumna;
            for (fila=0;fila< dgvSabanaMedicamentos.RowCount;fila++)
            {
                for (indiceColumna = 3; indiceColumna < 27; indiceColumna++)
                {
                    if (dgvSabanaMedicamentos.Rows[fila].Cells[indiceColumna].Value.ToString() == ConstanteGeneral.SABANA_SIN_APLICAR) {
                        DataGridViewButtonCell cell = new DataGridViewButtonCell();
                        DataGridViewCellCollection celdaActual = dgvSabanaMedicamentos.Rows[fila].Cells;
                        celdaActual[indiceColumna] = cell;
                        celdaActual[indiceColumna].Value = ConstanteGeneral.SABANA_SIN_APLICAR;
                        celdaActual[indiceColumna].Style.BackColor = Color.White;
                    }
                }
            }*/
        }
      

        private void pintarDGVGoteo()
        {
            dgvSabanaGoteo.DefaultCellStyle.Font = new Font("[FontFamily: Name=Arial Narrow]", 7);
            pintarCeldas(ref dgvSabanaGoteo);
            dgvSabanaGoteo.Columns["idMedicamentoGoteo"].Visible = false;
        }
        private void pintarCeldas(ref DataGridView dgv)
        {
           /* Object valorCelda;

            int fila, columna;
            for (fila = 0; fila < dgv.RowCount; fila++)
            {
                for (columna = 3; columna < dgv.ColumnCount - 1; columna++)
                {
                    valorCelda = dgv.Rows[fila].Cells[columna].Value;
                    if (((dtpFecha.MinDate.Date == dtpFecha.Value.Date &&
                         (columna - 3) < (dtpFecha.MinDate).Hour) ||
                        (dtpFecha.MaxDate.Date == dtpFecha.Value.Date &&
                         (columna - 3) > dtpFecha.MaxDate.Hour)))
                    {
                        dgv.Rows[fila].Cells[columna].Value = "";
                        dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightGray;
                    } else if (dgv.Name == dgvSabanaMedicamentos.Name) {
                        switch (valorCelda.ToString())
                        {
                            case "":
                                dgv.Rows[fila].Cells[columna].Style.BackColor = Color.White;
                                break;
                            case ConstanteGeneral.SABANA_SIN_APLICAR:
                                dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightYellow;
                                break;
                            case ConstanteGeneral.SABANA_MODIFICADO:
                                dgv.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                                dgv.Rows[fila].Cells[columna].Style.BackColor = Color.Blue;
                                break;
                            case ConstanteGeneral.SABANA_SUSPENDIDO:
                                dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightCoral;
                                break;
                            default:
                                dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightGreen;
                                break;
                        }
                    } else {

                        if (valorCelda.ToString() == "")
                        {
                            dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightGray;
                        } else if (GeneralC.IsNumeric(valorCelda.ToString()) &&
                           valorCelda.ToString() == ConstanteGeneral.SABANA_SIN_APLICAR) {
                            dgv.Rows[fila].Cells[columna].Style.BackColor = Color.White;
                        } else if (GeneralC.IsNumeric(valorCelda.ToString()) &&
                           valorCelda.ToString() == ConstanteGeneral.SABANA_MODIFICADO) {
                            dgv.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                            dgv.Rows[fila].Cells[columna].Style.BackColor = Color.Blue;
                        } else if (GeneralC.IsNumeric(valorCelda.ToString()) && 
                                   valorCelda.ToString() == ConstanteGeneral.SABANA_SUSPENDIDO) {
                            dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightCoral;
                        } else{
                            dgv.Rows[fila].Cells[columna].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }*/
        }
        private void verificarTab()
        {
            if (tabControlGalactus1.SelectedIndex == 0)
            {
                pintarDGVMedicamentos();
            }
            else
            {
                pintarDGVGoteo();
            }
        }

        private void tabControlGalactus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarTab();
        }       

        private void dgvSabanaMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (tsbGuardar.Enabled) {
                if (e.RowIndex >=0 && dgvSabanaMedicamentos.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    dgvSabanaMedicamentos.Rows[e.RowIndex].Cells[e.ColumnIndex] = cell;
                    dgvSabanaMedicamentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Sesion.nombre.ToString().Substring(0, 2);
                    dgvSabanaMedicamentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                }
            }*/
        }

        private void dgvSabanaMedicamentos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >=0 && dgvSabanaMedicamentos.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell) {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image imagen = Properties.Resources.opciondelete;
                e.Graphics.DrawImage(imagen, e.CellBounds.Left + 6, e.CellBounds.Top + 4);
                e.Handled = true;
            }
        }

        private void dgvSabanaMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (tsbGuardar.Enabled)
            {
                int indiceFila, indiceColumna;
                indiceFila = dgvSabanaMedicamentos.CurrentCell.RowIndex;
                indiceColumna = dgvSabanaMedicamentos.CurrentCell.ColumnIndex;
                if (indiceFila >= 0 && e.KeyCode == Keys.Delete) {
                    if (dgvSabanaMedicamentos.Rows[indiceFila].Cells[indiceColumna].Style.BackColor == Color.LightGreen)
                    {
                        DataGridViewButtonCell cell = new DataGridViewButtonCell();
                        DataGridViewCellCollection celdaActual = dgvSabanaMedicamentos.Rows[indiceFila].Cells;
                        celdaActual[indiceColumna] = cell;
                        celdaActual[indiceColumna].Value = ConstanteGeneral.SABANA_SIN_APLICAR;
                        celdaActual[indiceColumna].Style.BackColor = Color.White;
                    }
                    
                }
            
            }*/
               
        }

        private void dgvSabanaGoteo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
        if (tsbGuardar.Enabled)
            {
                if (dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.LightGray &&
                dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.LightCoral &&
                dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Blue &&
                GeneralC.IsNumeric(dgvSabanaGoteo.Columns[e.ColumnIndex].HeaderText))
                {
                    dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                }

            }*/
        }

        private void dgvSabanaGoteo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*if (!GeneralC.IsNumeric(dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())) {
                dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
        } else {
                dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = double.Parse(dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
        if (double.Parse(dgvSabanaGoteo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) >= 10000)
            {
                Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
                dgvSabanaGoteo.CancelEdit();
            }*/
        }
    }
}
