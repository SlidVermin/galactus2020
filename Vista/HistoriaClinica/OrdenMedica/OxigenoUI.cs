using Entidad.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class OxigenoUI : Form
    {
        public bool edicion = false;
        public int idAtencion { get; set; }
        public OrdenClinicaOxigeno oxigeno { get; set; }
        public OxigenoUI()
        {
            InitializeComponent();
        }

        private void OxigenoUI_Load(object sender, EventArgs e)
        {

        }
        public void enlazarDgv()
        {
            /*if (oxigeno != null)
            {
                dgvOrdenOxigeno.AutoGenerateColumns = false;
                dgvOrdenOxigeno.DataSource = oxigeno.tblOxigeno;
            }*/
        }
        void cargarOxigeno(DataRow filaResultado)
        {
            dgvOrdenOxigeno.Rows[dgvOrdenOxigeno.CurrentCell.RowIndex].Cells["dgIdOxigenoOrden"].Value = filaResultado.Field<Int32>("Código");
            dgvOrdenOxigeno.Rows[dgvOrdenOxigeno.CurrentCell.RowIndex].Cells["dgDescripcionOrdenOxigeno"].Value = filaResultado.Field<string>("Descripción");
        }
        private void dgvOrdenOxigeno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*GeneralUI.deshabilitarColumnas(dgvOrdenOxigeno);
            if (edicion)
            {
                dgvOrdenOxigeno.Columns["dgSuspenderOxigenoOrden"].ReadOnly = false;
                if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenOxigeno, "quitar") & e.RowIndex > -1)
                {
                    bool filaVacia;
                    int filaActual;
                    filaActual = dgvOrdenOxigeno.CurrentCell.RowIndex;

                    filaVacia = ((dgvOrdenOxigeno.Rows[filaActual].Cells[2].Value == null) ||
                    string.IsNullOrEmpty(dgvOrdenOxigeno.Rows[filaActual].Cells[2].Value.ToString())) ? true : false;

                    if (!filaVacia && Mensajes.preguntaAnular())
                    {
                        dgvOrdenOxigeno.Rows[filaActual].Cells["dgIdOxigenoOrden"].Value = DBNull.Value;
                        dgvOrdenOxigeno.Rows[filaActual].Cells["dgDescripcionOrdenOxigeno"].Value = DBNull.Value;
                        dgvOrdenOxigeno.Rows[filaActual].Cells["dgObservacionOxigeno"].Value = DBNull.Value;
                        dgvOrdenOxigeno.Rows[filaActual].Cells["dgSuspenderOxigenoOrden"].Value = false;

                    }
                }
                else if (GeneralUI.verificarUbicacionCelda(e, dgvOrdenOxigeno, "agregar") & e.RowIndex >-1)
                {
                    /*try
                    {
                        List<string> parametros = new List<string>();

                        DataTable tablaParametros = new DataTable();
                        DataTable tablasSeleccionado = new DataTable();

                        tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                        tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                        object[] myObjArray = { "@pIdAtencion", idAtencion };
                        object[] myObjArray1 = { "@pFiltro", "" };

                        DataView view = new DataView(oxigeno.tblOxigeno);

                        tablasSeleccionado = view.ToTable(true, new string[] { "idOxigeno" }).Copy();
                        tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                        object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

                        tablaParametros.Rows.Add(myObjArray);
                        tablaParametros.Rows.Add(myObjArray1);
                        tablaParametros.Rows.Add(myObjArray2);

                        GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_OXIGENO,
                                                    parametros,
                                                    new GeneralC.cargarInfoFila(cargarOxigeno),
                                                    Mensajes.BUSQUEDA_PROCEDIMIENTOS,
                                                    true,
                                                    null,
                                                    tablasSeleccionado,
                                                    tablaParametros);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                abrirObservacion();
            }*/
        }
        private void abrirObservacion()
        {
            GeneralUI.abrirVentanaEntradaDatos(ref dgvOrdenOxigeno,
                                              "Observación",
                                              "dgDescripcionOrdenOxigeno",
                                              edicion);
        }

        private void dgvOrdenOxigeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            abrirObservacion();
        }
    }
}
