using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Vista.General;

namespace Vista.HistoriaClinica
{
    public partial class ListadoPacienteUI : Form
    {
        /*ListadoPaciente listaPaciente = new ListadoPaciente();
        private bool auditoria;*/
        public ListadoPacienteUI()
        {
            InitializeComponent();
        }

        void generarPDF()
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"D:\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Roberto Torres");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Mi primer documento PDF"));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
            clNombre.BorderWidth = 0;

            clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
            clApellido.BorderWidth = 0;

            clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
            clPais.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();
            Process.Start("D:/prueba.pdf");
        }
        private void ListadoPaciente_Load(object sender, EventArgs e)
        {
           /* auditoria = false; //esto está quemado para pruebas, siempre será HC
            listaPaciente.idMenu = Tag.ToString();
            switch (listaPaciente.idMenu)
            {
                case ConstanteGeneral.MENU_ATENCION_MEDICA:
                    lbTitulo.Text = ConstanteGeneral.TITULO_ATENCIÓN_MEDICA;
                    break;
                case ConstanteGeneral.MENU_ATENCION_ENFERMERIA:
                    lbTitulo.Text = ConstanteGeneral.TITULO_ATENCIÓN_ENFERMERIA;
                    break;
            }
            GeneralC.llenarCombo(ConsultasHistoriaClinica.ESTADO_ATENCION + " " + Util.Constantes.ConstanteGeneral.ESTADO_ATENCION + "",
                                  Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                                  Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                                  cbEstado);

            cbEstado.SelectedValue = ConstanteGeneral.ESTADO_INICIADO;
            listaPaciente.idEstadoAtencion = ConstanteGeneral.ESTADO_INICIADO;
            establecerGridview();*/


        }

        public void preCargar()
        {
            /*listaPaciente.filtro = textBox1.Text;
            listaPaciente.listarPacientes();
            dibujarGridView();*/
        }

        public void dibujarGridView()
        {
            //for (int i = 0; i < dgvListaPaciente.Rows.Count; i++)
            //{
            //    dgvListaPaciente.Rows[i].Cells["dgAtencion"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            //    dgvListaPaciente.Rows[i].Cells["dgAdmision"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));

            //    dgvListaPaciente.Rows[i].Cells["dgArea"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            //    dgvListaPaciente.Rows[i].Cells["dgEntorno"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            //}
        }
        public void cargar()
        {
            /*listaPaciente.listarPacientes();
            dgvListaPaciente.DataSource = listaPaciente.dtPacientes;*/
        }

        public void establecerGridview()
        {

            /*dgvListaPaciente.Columns["dgAtencion"].DataPropertyName = "Atencion";
            dgvListaPaciente.Columns["dgAdmision"].DataPropertyName = "Admision";
            dgvListaPaciente.Columns["dgPaciente"].DataPropertyName = "Paciente";
            dgvListaPaciente.Columns["dgFechaIngreso"].DataPropertyName = "Fecha Ingreso";
            dgvListaPaciente.Columns["dgEntorno"].DataPropertyName = "Entorno";
            dgvListaPaciente.Columns["dgArea"].DataPropertyName = "Area";
            dgvListaPaciente.Columns["dgEstancia"].DataPropertyName = "Estancia";
            dgvListaPaciente.Columns["dgEdad"].DataPropertyName = "Edad";
            dgvListaPaciente.Columns["dgGenero"].DataPropertyName = "Genero";
            dgvListaPaciente.Columns["dgCliente"].DataPropertyName = "Cliente";
            dgvListaPaciente.Columns["dgColor"].DataPropertyName = "Color";
            dgvListaPaciente.Columns["dgEgreso"].DataPropertyName = "Fecha egreso";
            dgvListaPaciente.Columns["dgNeonatal"].DataPropertyName = "EsNeonatal";

            cargar();*/

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvListaPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*switch (listaPaciente.idMenu)
            {
                case ConstanteGeneral.MENU_ATENCION_MEDICA:
                    HistoriaClinicaUI formHistoriaClinica = new HistoriaClinicaUI();
                    formHistoriaClinica.obtenerDatosPaciente(listaPaciente, Convert.ToInt32(dgvListaPaciente.Rows[dgvListaPaciente.CurrentCell.RowIndex].Cells["dgAtencion"].Value), auditoria,
                                                             Convert.ToBoolean(dgvListaPaciente.Rows[dgvListaPaciente.CurrentCell.RowIndex].Cells["dgNeonatal"].Value));
                    formHistoriaClinica.Show();
                    break;
                case ConstanteGeneral.MENU_ATENCION_ENFERMERIA:
                    FichaEnfermeriaUI formHistoriaEnfermeria = new FichaEnfermeriaUI();
                    formHistoriaEnfermeria.obtenerDatosPaciente(listaPaciente, Convert.ToInt32(dgvListaPaciente.Rows[dgvListaPaciente.CurrentCell.RowIndex].Cells["dgAtencion"].Value), auditoria);
                    formHistoriaEnfermeria.Show();
                    break;
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(ConsultasHistoriaClinica.AREA_ATENCION,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarAreas),
                                                   Mensajes.BUSQUEDA_AREA, true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }*/
        }
        public void cargarAreas(DataRow filas)
        {
            /*listaPaciente.idArea = filas.Field<int>("IdArea");
            txtArea.Text = filas.Field<String>("Area");
            preCargar();*/
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
           /* if (txtArea.Text.Equals(String.Empty))
            {
                cbEntorno.Enabled = false;
                btLimpiar.Visible = false;
            }
            else
            {
                GeneralC.llenarCombo(ConsultasHistoriaClinica.ENTORNO_ATENCION + " " + listaPaciente.idArea + "",
                             Util.Constantes.ConstanteGeneral.VALUE_MEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAY_MEMBER,
                             cbEntorno);
                cbEntorno.Enabled = true;
                btLimpiar.Visible = true;
            }*/
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbEstado.SelectedIndex != 0)
            {
                listaPaciente.idEstadoAtencion = Convert.ToInt16(cbEstado.SelectedValue);
                preCargar();
            }*/

        }

        private void cbEntorno_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cbEntorno.SelectedIndex != 0)
            {
                listaPaciente.idEntorno = Convert.ToInt16(cbEntorno.SelectedValue);
                preCargar();
            }
            else
            {
                listaPaciente.idEntorno = 0;
                preCargar();
            }*/
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            /*txtArea.Clear();
            listaPaciente.idArea = 0;
            cbEntorno.SelectedValue = -1;
            preCargar();*/
        }

        private void ListadoPacienteUI_Shown(object sender, EventArgs e)
        {
            dibujarGridView();
            dgvListaPaciente.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void buscarHCPacienteBtn_Click(object sender, EventArgs e)
        {
            preCargar();
            generarPDF();

        }
    }
}
