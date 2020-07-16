using System.util;

namespace Vista.HistoriaClinica.Resultado
{
    partial class ResultadoLaboratorioUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tstImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgParametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpResultado = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpMuestra = new System.Windows.Forms.DateTimePicker();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoAdministradora = new System.Windows.Forms.TextBox();
            this.txtAdministradora = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtOrdenMedica = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtAtencion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tstMenuPatron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.pnlInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstModificar,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbAnular,
            this.tstImprimir});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 555);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 53;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tstModificar
            // 
            this.tstModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstModificar.Image = Properties.Resources.bt_editar;
            this.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstModificar.Name = "tstModificar";
            this.tstModificar.Size = new System.Drawing.Size(78, 22);
            this.tstModificar.Text = "Modificar";
            this.tstModificar.Click += new System.EventHandler(this.tstModificar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.Image = Properties.Resources.btn_guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = Properties.Resources.btn_cancelar;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAnular.Image = Vista.Properties.Resources.btn_anular;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // tstImprimir
            // 
            this.tstImprimir.Image = Properties.Resources.print__2_;
            this.tstImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstImprimir.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstImprimir.Name = "tstImprimir";
            this.tstImprimir.Size = new System.Drawing.Size(73, 22);
            this.tstImprimir.Text = "Imprimir";
            this.tstImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tstImprimir.Click += new System.EventHandler(this.tstImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(938, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Resultados de laboratorio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlInformacion);
            this.panel1.Location = new System.Drawing.Point(23, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 501);
            this.panel1.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 10139;
            this.label13.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(16, 431);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacion.Size = new System.Drawing.Size(896, 67);
            this.txtObservacion.TabIndex = 10138;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvResultados);
            this.panel2.Location = new System.Drawing.Point(15, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 200);
            this.panel2.TabIndex = 6;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AllowUserToResizeColumns = false;
            this.dgvResultados.AllowUserToResizeRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCodigo,
            this.dgParametro,
            this.dgDescripcion,
            this.dgResultado,
            this.dgReferencia});
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.Size = new System.Drawing.Size(895, 198);
            this.dgvResultados.TabIndex = 4;
            // 
            // dgCodigo
            // 
            this.dgCodigo.HeaderText = "Codigo";
            this.dgCodigo.Name = "dgCodigo";
            this.dgCodigo.Visible = false;
            this.dgCodigo.Width = 46;
            // 
            // dgParametro
            // 
            this.dgParametro.HeaderText = "Parametro";
            this.dgParametro.Name = "dgParametro";
            this.dgParametro.Visible = false;
            this.dgParametro.Width = 61;
            // 
            // dgDescripcion
            // 
            this.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcion.HeaderText = "Descripción";
            this.dgDescripcion.Name = "dgDescripcion";
            this.dgDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgResultado
            // 
            this.dgResultado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgResultado.HeaderText = "Resultado";
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgReferencia
            // 
            this.dgReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgReferencia.HeaderText = "Referencia";
            this.dgReferencia.Name = "dgReferencia";
            this.dgReferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(18, 184);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(100, 20);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Información del la Atención";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.label6);
            this.pnlInformacion.Controls.Add(this.dtpResultado);
            this.pnlInformacion.Controls.Add(this.label12);
            this.pnlInformacion.Controls.Add(this.dtpMuestra);
            this.pnlInformacion.Controls.Add(this.txtProcedimiento);
            this.pnlInformacion.Controls.Add(this.label11);
            this.pnlInformacion.Controls.Add(this.dtFecha);
            this.pnlInformacion.Controls.Add(this.label4);
            this.pnlInformacion.Controls.Add(this.txtCodigoAdministradora);
            this.pnlInformacion.Controls.Add(this.txtAdministradora);
            this.pnlInformacion.Controls.Add(this.label10);
            this.pnlInformacion.Controls.Add(this.label9);
            this.pnlInformacion.Controls.Add(this.txtServicio);
            this.pnlInformacion.Controls.Add(this.txtPaciente);
            this.pnlInformacion.Controls.Add(this.txtOrdenMedica);
            this.pnlInformacion.Controls.Add(this.txtIdentificacion);
            this.pnlInformacion.Controls.Add(this.txtAtencion);
            this.pnlInformacion.Controls.Add(this.label8);
            this.pnlInformacion.Controls.Add(this.label7);
            this.pnlInformacion.Controls.Add(this.label3);
            this.pnlInformacion.Controls.Add(this.label5);
            this.pnlInformacion.Location = new System.Drawing.Point(15, 35);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(897, 140);
            this.pnlInformacion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10137;
            this.label6.Text = "Resultado:";
            // 
            // dtpResultado
            // 
            this.dtpResultado.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpResultado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResultado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResultado.Location = new System.Drawing.Point(396, 109);
            this.dtpResultado.Name = "dtpResultado";
            this.dtpResultado.Size = new System.Drawing.Size(133, 21);
            this.dtpResultado.TabIndex = 10136;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 10135;
            this.label12.Text = "Toma de muestra:";
            // 
            // dtpMuestra
            // 
            this.dtpMuestra.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpMuestra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMuestra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMuestra.Location = new System.Drawing.Point(135, 109);
            this.dtpMuestra.Name = "dtpMuestra";
            this.dtpMuestra.Size = new System.Drawing.Size(133, 21);
            this.dtpMuestra.TabIndex = 10134;
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.Location = new System.Drawing.Point(396, 81);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(481, 21);
            this.txtProcedimiento.TabIndex = 47;
            this.txtProcedimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(297, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Procedimiento:";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(726, 31);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(151, 21);
            this.dtFecha.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha:";
            // 
            // txtCodigoAdministradora
            // 
            this.txtCodigoAdministradora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAdministradora.Location = new System.Drawing.Point(135, 54);
            this.txtCodigoAdministradora.Name = "txtCodigoAdministradora";
            this.txtCodigoAdministradora.Size = new System.Drawing.Size(100, 21);
            this.txtCodigoAdministradora.TabIndex = 27;
            this.txtCodigoAdministradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdministradora
            // 
            this.txtAdministradora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministradora.Location = new System.Drawing.Point(241, 54);
            this.txtAdministradora.Name = "txtAdministradora";
            this.txtAdministradora.Size = new System.Drawing.Size(636, 21);
            this.txtAdministradora.TabIndex = 26;
            this.txtAdministradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Administradora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Entorno:";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(679, 7);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(198, 21);
            this.txtServicio.TabIndex = 23;
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(135, 31);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(456, 21);
            this.txtPaciente.TabIndex = 22;
            // 
            // txtOrdenMedica
            // 
            this.txtOrdenMedica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenMedica.Location = new System.Drawing.Point(135, 81);
            this.txtOrdenMedica.Name = "txtOrdenMedica";
            this.txtOrdenMedica.Size = new System.Drawing.Size(151, 21);
            this.txtOrdenMedica.TabIndex = 21;
            this.txtOrdenMedica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(396, 7);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(195, 21);
            this.txtIdentificacion.TabIndex = 20;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtencion
            // 
            this.txtAtencion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtencion.Location = new System.Drawing.Point(135, 7);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Size = new System.Drawing.Size(151, 21);
            this.txtAtencion.TabIndex = 19;
            this.txtAtencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Orden Médica:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Atención:";
            // 
            // ResultadoLaboratorioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(969, 580);
            this.MinimumSize = new System.Drawing.Size(969, 580);
            this.Name = "ResultadoLaboratorioUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoLaboratorioUI";
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoAdministradora;
        private System.Windows.Forms.TextBox txtAdministradora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtOrdenMedica;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtAtencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker dtpResultado;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.DateTimePicker dtpMuestra;
        public System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.ToolStripButton tstImprimir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgReferencia;
    }
}