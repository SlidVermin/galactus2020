using Entidad.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class ProcedimientosUI : Form
    {
        public bool edicion = false;
        public int idAtencion { get; set; }
        public OrdenClinicaProcedimiento procedimientos { get; set; }
        public ProcedimientosUI()
        {
            InitializeComponent();
        }
        private void ProcedimientosUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }
        void inicializarForm()
        {
        }
        public void enlazarDgv()
        {
            /*if (procedimientos != null)
            {
                dgvProcedimientos.AutoGenerateColumns = false;
                dgvProcedimientos.Columns["cups"].DataPropertyName = "cups";
                dgvProcedimientos.Columns["descripcion"].DataPropertyName = "descripcion";
                dgvProcedimientos.Columns["cantidad"].DataPropertyName = "cantidad";
                dgvProcedimientos.Columns["justificacion"].DataPropertyName = "Observacion";
                dgvProcedimientos.DataSource = procedimientos.tblProcedimientos;
            }*/

        }
        void cargarProcedimiento(DataRow filaResultado)
        {
            DataRowCollection filas = procedimientos.tblProcedimientos.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idProcedimiento"] = filaResultado.Field<int>("ID");
            filas[cantidad]["cups"] = filaResultado.Field<string>("Código");
            filas[cantidad]["descripcion"] = filaResultado.Field<string>("Descripción");
            filas[cantidad]["cantidad"] = 0;
            filas.Add();
        }
        private void dgvProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)
            {
                GeneralUI.deshabilitarColumnas(dgvProcedimientos);
                if (edicion)
                {
                    dgvProcedimientos.Columns["cantidad"].ReadOnly = false;
                    if (GeneralUI.verificarUbicacionCelda(e, dgvProcedimientos, "quitar") & e.RowIndex < dgvProcedimientos.Rows.Count - 1)
                    {
                        if (Mensajes.preguntaAnular())
                        {
                            dgvProcedimientos.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    else if (GeneralUI.verificarUbicacionCelda(e, dgvProcedimientos, "agregar") & e.RowIndex == dgvProcedimientos.Rows.Count - 1)
                    {
                        try
                        {
                            List<string> parametros = new List<string>();

                            DataTable tablaParametros = new DataTable();
                            DataTable tablasSeleccionado = new DataTable();

                            tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                            tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                            object[] myObjArray = { "@pIdAtencion", idAtencion };
                            object[] myObjArray1 = { "@pFiltro", "" };

                            DataView view = new DataView(procedimientos.tblProcedimientos);

                            tablasSeleccionado = view.ToTable(true, new string[] { "idProcedimiento" }).Copy();
                            tablasSeleccionado.Columns.Add("valor");
                            tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                            object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

                            tablaParametros.Rows.Add(myObjArray);
                            tablaParametros.Rows.Add(myObjArray1);
                            tablaParametros.Rows.Add(myObjArray2);

                            GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_PROCEDIMIENTOS,
                                                        parametros,
                                                        new GeneralC.cargarInfoFila(cargarProcedimiento),
                                                        Mensajes.BUSQUEDA_PROCEDIMIENTOS,
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
                abrirObservacion();
            }*/
            
        }
        private void abrirObservacion()
        {
            GeneralUI.abrirVentanaEntradaDatos(ref dgvProcedimientos,
                                              "Justificación",
                                              "cups",
                                              edicion);
        }
             
        
        
        private void dgvProcedimientos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dgvProcedimientos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvProcedimientos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }
        }

        private void dgvProcedimientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            abrirObservacion();
        }

        private void dgvProcedimientos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvProcedimientos.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }
    }
}
