using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vista.General;

namespace Vista.HistoriaClinica.OrdenMedica
{
    public partial class MezclaUI : Form
    {
        private DataTable dtMezcla;
        private int idMedicamentoMezc;
        private int idAtencion;
        private bool auditoria;
        private DateTime fechaOrden;
        public MezclaUI()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void MezclaUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MezclaUI_Load(object sender, EventArgs e)
        {
            dgvMezcla.DataSource = GeneralUI.copiarTablaCondicional(dtMezcla, "idMedicamento =" + idMedicamentoMezc + "");
            if (tsBtGuardar.Enabled)
            {
               ((DataTable)dgvMezcla.DataSource).Rows.Add();
                asignarIdMedicamento();
                dgvMezcla.Columns["Unidad"].DisplayIndex = 4;
            }
            
        }        
     
        public void obtenerEstado(bool permitirCambios)
        {
            tsBtGuardar.Enabled = permitirCambios;
            GeneralUI.deshabilitarColumnas(dgvMezcla);
            dgvMezcla.Columns["Dosis"].ReadOnly = !permitirCambios;
        }

        private void asignarIdMedicamento() {
            int i;
            for (i = 0;i< dtMezcla.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dtMezcla.Rows[i]["idMedicamento"].ToString())) 
                {
                    dtMezcla.Rows[i]["idMedicamento"] = idMedicamentoMezc;
                }
                
            }
            
        }
       
        public void obtenerDatos(ref DataTable dt ,int codigo,int vidAtencion,DateTime vfechaOrden,bool vAuditoria)
        {
            dtMezcla = dt;
            idMedicamentoMezc = codigo;
            fechaOrden = vfechaOrden;
            idAtencion = vidAtencion;
            auditoria = vAuditoria;
        }
        
        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            dgvMezcla.EndEdit();
            ((DataTable) dgvMezcla.DataSource).AcceptChanges();
            if (GeneralUI.validarCantidad((DataTable)dgvMezcla.DataSource, "Dosis", true)) {
                int i;
                for (i = 0;i<dtMezcla.Rows.Count; i++)
                {
                    if (int.Parse(dtMezcla.Rows[i]["idMedicamento"].ToString()) == idMedicamentoMezc)
                    {
                        dtMezcla.Rows[i].Delete();
                    }
                }
                dtMezcla.AcceptChanges();
                dtMezcla.Merge((DataTable)dgvMezcla.DataSource);
                asignarIdMedicamento();
                dtMezcla.Rows.RemoveAt(dtMezcla.Rows.Count - 1);
                DialogResult = DialogResult.OK;
            }
            
        }

        private void dgvMezcla_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvMezcla.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }
        void cargarMezcla(DataRow filaResultado)
        {
            DataRowCollection filas = ((DataTable)dgvMezcla.DataSource).Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idEquivalencia"] = filaResultado.Field<int>("ID");
            filas[cantidad]["Descripción"] = filaResultado.Field<string>("Descripción");
            filas[cantidad]["Unidad"] = filaResultado.Field<string>("Unidad");
            filas[cantidad]["Dosis"] = 0;            
            filas.Add();
            dgvMezcla.EndEdit();

        }
        void agregarMezcla()
        {
            /*try
            {
                List<string> parametros = new List<string>();
                DataTable tablasSeleccionado = new DataTable();
                DataTable tablaParametros = new DataTable();

                tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                object[] myObjArray = { "@pAuditoria", auditoria };
                object[] myObjArray1 = { "@pIdAtencion", idAtencion };
                object[] myObjArray2 = { "@pFechaOrden", fechaOrden.Date };
                object[] myObjArray3 = { "@pFiltro", "" };


                tablaParametros.Rows.Add(myObjArray);
                tablaParametros.Rows.Add(myObjArray1);
                tablaParametros.Rows.Add(myObjArray2);
                tablaParametros.Rows.Add(myObjArray3);

                OperacionesBD.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_MEZCLA,
                                            parametros,
                                            new OperacionesBD.cargarInfoFila(cargarMezcla),
                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                            true,
                                            null,
                                            tablasSeleccionado,
                                            tablaParametros);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        private void dgvMezcla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                GeneralUI.deshabilitarColumnas(dgvMezcla);
                if (tsBtGuardar.Enabled)
                {
                    dgvMezcla.Columns["Dosis"].ReadOnly = false;
                    int fila = dgvMezcla.CurrentCell.RowIndex;
                    if (GeneralUI.verificarUbicacionCelda(e, dgvMezcla, "quitar") & e.RowIndex < dgvMezcla.Rows.Count - 1)
                    {
                        if (Mensajes.preguntaAnular())
                        {
                           dgvMezcla.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    else if (GeneralUI.verificarUbicacionCelda(e, dgvMezcla, "agregar") & e.RowIndex == dgvMezcla.Rows.Count - 1)
                    {
                        agregarMezcla();
                    }
                    
                }
            }
        }
    }
}
