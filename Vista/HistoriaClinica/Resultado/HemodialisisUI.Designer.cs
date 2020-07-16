using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    partial class HemodialisisUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcOrdenMedica = new TabControlGalactus();
            this.tpNota = new System.Windows.Forms.TabPage();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.tpNotaSigno = new System.Windows.Forms.TabPage();
            this.txtNotaSigno = new System.Windows.Forms.TextBox();
            this.tabMedicamento = new System.Windows.Forms.TabPage();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.agregarMed = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitarMed = new System.Windows.Forms.DataGridViewImageColumn();
            this.codigoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tsbBuscarNit = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tstImprimir = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.tpNota.SuspendLayout();
            this.tpNotaSigno.SuspendLayout();
            this.tabMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.pnlInformacion.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tcOrdenMedica);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlInformacion);
            this.panel1.Location = new System.Drawing.Point(23, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 497);
            this.panel1.TabIndex = 5;
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpNota);
            this.tcOrdenMedica.Controls.Add(this.tpNotaSigno);
            this.tcOrdenMedica.Controls.Add(this.tabMedicamento);
            this.tcOrdenMedica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(15, 154);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(897, 340);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 58;
            // 
            // tpNota
            // 
            this.tpNota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpNota.Controls.Add(this.txtNota);
            this.tpNota.Location = new System.Drawing.Point(124, 4);
            this.tpNota.Name = "tpNota";
            this.tpNota.Padding = new System.Windows.Forms.Padding(3);
            this.tpNota.Size = new System.Drawing.Size(769, 332);
            this.tpNota.TabIndex = 0;
            this.tpNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNota.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(3, 3);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNota.Size = new System.Drawing.Size(763, 326);
            this.txtNota.TabIndex = 40;
            // 
            // tpNotaSigno
            // 
            this.tpNotaSigno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpNotaSigno.Controls.Add(this.txtNotaSigno);
            this.tpNotaSigno.Location = new System.Drawing.Point(124, 4);
            this.tpNotaSigno.Name = "tpNotaSigno";
            this.tpNotaSigno.Size = new System.Drawing.Size(769, 332);
            this.tpNotaSigno.TabIndex = 1;
            this.tpNotaSigno.Text = "Nota Signos";
            // 
            // txtNotaSigno
            // 
            this.txtNotaSigno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotaSigno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaSigno.Location = new System.Drawing.Point(0, 0);
            this.txtNotaSigno.Multiline = true;
            this.txtNotaSigno.Name = "txtNotaSigno";
            this.txtNotaSigno.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotaSigno.Size = new System.Drawing.Size(769, 332);
            this.txtNotaSigno.TabIndex = 41;
            // 
            // tabMedicamento
            // 
            this.tabMedicamento.Controls.Add(this.dgvMedicamento);
            this.tabMedicamento.Location = new System.Drawing.Point(124, 4);
            this.tabMedicamento.Name = "tabMedicamento";
            this.tabMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicamento.Size = new System.Drawing.Size(769, 332);
            this.tabMedicamento.TabIndex = 2;
            this.tabMedicamento.Text = "Medicamentos";
            this.tabMedicamento.UseVisualStyleBackColor = true;
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.AllowUserToDeleteRows = false;
            this.dgvMedicamento.AllowUserToResizeColumns = false;
            this.dgvMedicamento.AllowUserToResizeRows = false;
            this.dgvMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agregarMed,
            this.quitarMed,
            this.codigoMed,
            this.descripcionMed,
            this.CantidadMed});
            this.dgvMedicamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicamento.Location = new System.Drawing.Point(3, 3);
            this.dgvMedicamento.MultiSelect = false;
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            this.dgvMedicamento.RowHeadersVisible = false;
            this.dgvMedicamento.Size = new System.Drawing.Size(763, 326);
            this.dgvMedicamento.TabIndex = 4;
            this.dgvMedicamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamento_CellClick);
            this.dgvMedicamento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamento_CellEndEdit);
            this.dgvMedicamento.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMedicamento_DataError);
            // 
            // agregarMed
            // 
            this.agregarMed.HeaderText = "Agregar";
            this.agregarMed.Image = Properties.Resources.farmacia_ico;
            this.agregarMed.Name = "agregarMed";
            this.agregarMed.ReadOnly = true;
            this.agregarMed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agregarMed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.agregarMed.Width = 75;
            // 
            // quitarMed
            // 
            this.quitarMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quitarMed.HeaderText = "Quitar";
            this.quitarMed.Image = Properties.Resources.btn_anular;
            this.quitarMed.Name = "quitarMed";
            this.quitarMed.ReadOnly = true;
            this.quitarMed.Width = 50;
            // 
            // codigoMed
            // 
            this.codigoMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigoMed.HeaderText = "Código";
            this.codigoMed.Name = "codigoMed";
            this.codigoMed.ReadOnly = true;
            this.codigoMed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigoMed.Width = 75;
            // 
            // descripcionMed
            // 
            this.descripcionMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionMed.HeaderText = "Descripción";
            this.descripcionMed.Name = "descripcionMed";
            this.descripcionMed.ReadOnly = true;
            this.descripcionMed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CantidadMed
            // 
            this.CantidadMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.CantidadMed.DefaultCellStyle = dataGridViewCellStyle1;
            this.CantidadMed.HeaderText = "Cantidad";
            this.CantidadMed.Name = "CantidadMed";
            this.CantidadMed.ReadOnly = true;
            this.CantidadMed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CantidadMed.Width = 63;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(232, 352);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 20);
            this.label21.TabIndex = 5;
            this.label21.Text = "Signos Vitales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nota.";
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
            this.pnlInformacion.Controls.Add(this.dtpFecha);
            this.pnlInformacion.Controls.Add(this.label12);
            this.pnlInformacion.Controls.Add(this.txtProcedimiento);
            this.pnlInformacion.Controls.Add(this.label11);
            this.pnlInformacion.Controls.Add(this.dtFechaIngreso);
            this.pnlInformacion.Controls.Add(this.label4);
            this.pnlInformacion.Controls.Add(this.tsbBuscarNit);
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
            this.pnlInformacion.Size = new System.Drawing.Size(897, 113);
            this.pnlInformacion.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(694, 7);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(171, 21);
            this.dtpFecha.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(590, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Fecha:";
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.Location = new System.Drawing.Point(384, 81);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(481, 21);
            this.txtProcedimiento.TabIndex = 47;
            this.txtProcedimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(285, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Procedimiento:";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFechaIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaIngreso.Location = new System.Drawing.Point(694, 54);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(171, 21);
            this.dtFechaIngreso.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha Ingreso:";
            // 
            // tsbBuscarNit
            // 
            this.tsbBuscarNit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscarNit.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarNit.Location = new System.Drawing.Point(234, 5);
            this.tsbBuscarNit.Name = "tsbBuscarNit";
            this.tsbBuscarNit.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarNit.TabIndex = 43;
            this.tsbBuscarNit.UseVisualStyleBackColor = true;
            this.tsbBuscarNit.Click += new System.EventHandler(this.tsbBuscarNit_Click);
            // 
            // txtCodigoAdministradora
            // 
            this.txtCodigoAdministradora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAdministradora.Location = new System.Drawing.Point(123, 54);
            this.txtCodigoAdministradora.Name = "txtCodigoAdministradora";
            this.txtCodigoAdministradora.Size = new System.Drawing.Size(100, 21);
            this.txtCodigoAdministradora.TabIndex = 27;
            this.txtCodigoAdministradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdministradora
            // 
            this.txtAdministradora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministradora.Location = new System.Drawing.Point(229, 54);
            this.txtAdministradora.Name = "txtAdministradora";
            this.txtAdministradora.Size = new System.Drawing.Size(350, 21);
            this.txtAdministradora.TabIndex = 26;
            this.txtAdministradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Administradora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Entorno:";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(694, 31);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(171, 21);
            this.txtServicio.TabIndex = 23;
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(123, 31);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(456, 21);
            this.txtPaciente.TabIndex = 22;
            // 
            // txtOrdenMedica
            // 
            this.txtOrdenMedica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenMedica.Location = new System.Drawing.Point(123, 81);
            this.txtOrdenMedica.Name = "txtOrdenMedica";
            this.txtOrdenMedica.Size = new System.Drawing.Size(151, 21);
            this.txtOrdenMedica.TabIndex = 21;
            this.txtOrdenMedica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(384, 7);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(195, 21);
            this.txtIdentificacion.TabIndex = 20;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtencion
            // 
            this.txtAtencion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtencion.Location = new System.Drawing.Point(123, 7);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Size = new System.Drawing.Size(109, 21);
            this.txtAtencion.TabIndex = 19;
            this.txtAtencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Orden Médica:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Atención:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hemodialisis";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(938, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tstModificar,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbBuscar,
            this.tsbAnular,
            this.tstImprimir});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 555);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 48;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNuevo.Image = Properties.Resources.btn_nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            // tsbBuscar
            // 
            this.tsbBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscar.Image = Properties.Resources.btn_buscar;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAnular.Image = Properties.Resources.btn_anular;
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
            // 
            // HemodialisisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(969, 580);
            this.MinimumSize = new System.Drawing.Size(969, 580);
            this.Name = "HemodialisisUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HemodialisisUI";
            this.Load += new System.EventHandler(this.HemodialisisUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcOrdenMedica.ResumeLayout(false);
            this.tpNota.ResumeLayout(false);
            this.tpNota.PerformLayout();
            this.tpNotaSigno.ResumeLayout(false);
            this.tpNotaSigno.PerformLayout();
            this.tabMedicamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button tsbBuscarNit;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton tstImprimir;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.TabPage tpNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TabPage tpNotaSigno;
        private System.Windows.Forms.TextBox txtNotaSigno;
        private System.Windows.Forms.TabPage tabMedicamento;
        internal System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.DataGridViewImageColumn agregarMed;
        private System.Windows.Forms.DataGridViewImageColumn quitarMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMed;
    }
}