using Vista.General;

namespace Vista.HistoriaClinica.Resultado
{
    partial class InformeQuirurgicoUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tsbBuscarPaciente = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcOrdenMedica = new TabControlGalactus();
            this.tpDatosQuirurgicos = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pnlCaracteristica = new System.Windows.Forms.Panel();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tsbBuscarAnastesia = new System.Windows.Forms.Button();
            this.txtAnastesia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tsbBuscarAnastesiologo = new System.Windows.Forms.Button();
            this.txtAnastesiologo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tsbBuscarAyudante = new System.Windows.Forms.Button();
            this.txtAyudante = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tsbBuscarVia = new System.Windows.Forms.Button();
            this.txtVia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpProcedimientos = new System.Windows.Forms.TabPage();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMedicamento = new System.Windows.Forms.TabPage();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.agregarMed = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitarMed = new System.Windows.Forms.DataGridViewImageColumn();
            this.codigoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcOrdenMedica.SuspendLayout();
            this.tpDatosQuirurgicos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCaracteristica.SuspendLayout();
            this.tpProcedimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.tabMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tcOrdenMedica);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlInformacion);
            this.panel1.Location = new System.Drawing.Point(23, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 510);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Información del la Atención";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.txtProcedimiento);
            this.pnlInformacion.Controls.Add(this.label15);
            this.pnlInformacion.Controls.Add(this.dtFecha);
            this.pnlInformacion.Controls.Add(this.label4);
            this.pnlInformacion.Controls.Add(this.tsbBuscarPaciente);
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
            // txtProcedimiento
            // 
            this.txtProcedimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.Location = new System.Drawing.Point(384, 81);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(481, 21);
            this.txtProcedimiento.TabIndex = 49;
            this.txtProcedimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 15);
            this.label15.TabIndex = 48;
            this.label15.Text = "Procedimiento:";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(703, 54);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(162, 21);
            this.dtFecha.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha Ingreso:";
            // 
            // tsbBuscarPaciente
            // 
            this.tsbBuscarPaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscarPaciente.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarPaciente.Location = new System.Drawing.Point(234, 5);
            this.tsbBuscarPaciente.Name = "tsbBuscarPaciente";
            this.tsbBuscarPaciente.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarPaciente.TabIndex = 43;
            this.tsbBuscarPaciente.UseVisualStyleBackColor = true;
            this.tsbBuscarPaciente.Click += new System.EventHandler(this.tsbBuscarNit_Click);
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
            this.label9.Location = new System.Drawing.Point(608, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Entorno:";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(703, 31);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(162, 21);
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
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informe quirúrgico";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpDatosQuirurgicos);
            this.tcOrdenMedica.Controls.Add(this.tpProcedimientos);
            this.tcOrdenMedica.Controls.Add(this.tabMedicamento);
            this.tcOrdenMedica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(15, 154);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(897, 353);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 57;
            // 
            // tpDatosQuirurgicos
            // 
            this.tpDatosQuirurgicos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDatosQuirurgicos.Controls.Add(this.panel2);
            this.tpDatosQuirurgicos.Controls.Add(this.label21);
            this.tpDatosQuirurgicos.Controls.Add(this.pnlCaracteristica);
            this.tpDatosQuirurgicos.Location = new System.Drawing.Point(124, 4);
            this.tpDatosQuirurgicos.Name = "tpDatosQuirurgicos";
            this.tpDatosQuirurgicos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosQuirurgicos.Size = new System.Drawing.Size(769, 345);
            this.tpDatosQuirurgicos.TabIndex = 0;
            this.tpDatosQuirurgicos.Text = "Datos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNota);
            this.panel2.Location = new System.Drawing.Point(6, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 205);
            this.panel2.TabIndex = 19;
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(3, 3);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNota.Size = new System.Drawing.Size(748, 197);
            this.txtNota.TabIndex = 40;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "Nota Quirúrgica";
            // 
            // pnlCaracteristica
            // 
            this.pnlCaracteristica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCaracteristica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaracteristica.Controls.Add(this.dtpFechaFin);
            this.pnlCaracteristica.Controls.Add(this.dtpFechaInicio);
            this.pnlCaracteristica.Controls.Add(this.label17);
            this.pnlCaracteristica.Controls.Add(this.label16);
            this.pnlCaracteristica.Controls.Add(this.tsbBuscarAnastesia);
            this.pnlCaracteristica.Controls.Add(this.txtAnastesia);
            this.pnlCaracteristica.Controls.Add(this.label13);
            this.pnlCaracteristica.Controls.Add(this.tsbBuscarAnastesiologo);
            this.pnlCaracteristica.Controls.Add(this.txtAnastesiologo);
            this.pnlCaracteristica.Controls.Add(this.label14);
            this.pnlCaracteristica.Controls.Add(this.tsbBuscarAyudante);
            this.pnlCaracteristica.Controls.Add(this.txtAyudante);
            this.pnlCaracteristica.Controls.Add(this.label12);
            this.pnlCaracteristica.Controls.Add(this.tsbBuscarVia);
            this.pnlCaracteristica.Controls.Add(this.txtVia);
            this.pnlCaracteristica.Controls.Add(this.label11);
            this.pnlCaracteristica.Location = new System.Drawing.Point(6, 7);
            this.pnlCaracteristica.Name = "pnlCaracteristica";
            this.pnlCaracteristica.Size = new System.Drawing.Size(757, 99);
            this.pnlCaracteristica.TabIndex = 17;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpFechaFin.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(470, 10);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(134, 21);
            this.dtpFechaFin.TabIndex = 59;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(98, 10);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(134, 21);
            this.dtpFechaInicio.TabIndex = 58;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label17.Location = new System.Drawing.Point(371, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 57;
            this.label17.Text = "Fecha Fin:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label16.Location = new System.Drawing.Point(8, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Fecha Inicio:";
            // 
            // tsbBuscarAnastesia
            // 
            this.tsbBuscarAnastesia.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarAnastesia.Location = new System.Drawing.Point(722, 62);
            this.tsbBuscarAnastesia.Name = "tsbBuscarAnastesia";
            this.tsbBuscarAnastesia.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarAnastesia.TabIndex = 55;
            this.tsbBuscarAnastesia.UseVisualStyleBackColor = true;
            this.tsbBuscarAnastesia.Click += new System.EventHandler(this.tsbBuscarAnastesia_Click);
            // 
            // txtAnastesia
            // 
            this.txtAnastesia.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtAnastesia.Location = new System.Drawing.Point(470, 64);
            this.txtAnastesia.Name = "txtAnastesia";
            this.txtAnastesia.Size = new System.Drawing.Size(249, 21);
            this.txtAnastesia.TabIndex = 54;
            this.txtAnastesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(371, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 53;
            this.label13.Text = "Anastesia:";
            // 
            // tsbBuscarAnastesiologo
            // 
            this.tsbBuscarAnastesiologo.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarAnastesiologo.Location = new System.Drawing.Point(722, 35);
            this.tsbBuscarAnastesiologo.Name = "tsbBuscarAnastesiologo";
            this.tsbBuscarAnastesiologo.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarAnastesiologo.TabIndex = 52;
            this.tsbBuscarAnastesiologo.UseVisualStyleBackColor = true;
            this.tsbBuscarAnastesiologo.Click += new System.EventHandler(this.tsbBuscarAnastesiologo_Click);
            // 
            // txtAnastesiologo
            // 
            this.txtAnastesiologo.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtAnastesiologo.Location = new System.Drawing.Point(470, 37);
            this.txtAnastesiologo.Name = "txtAnastesiologo";
            this.txtAnastesiologo.Size = new System.Drawing.Size(249, 21);
            this.txtAnastesiologo.TabIndex = 51;
            this.txtAnastesiologo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label14.Location = new System.Drawing.Point(371, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Anastesiologo:";
            // 
            // tsbBuscarAyudante
            // 
            this.tsbBuscarAyudante.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarAyudante.Location = new System.Drawing.Point(318, 62);
            this.tsbBuscarAyudante.Name = "tsbBuscarAyudante";
            this.tsbBuscarAyudante.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarAyudante.TabIndex = 49;
            this.tsbBuscarAyudante.UseVisualStyleBackColor = true;
            this.tsbBuscarAyudante.Click += new System.EventHandler(this.tsbBuscarAyudante_Click);
            // 
            // txtAyudante
            // 
            this.txtAyudante.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtAyudante.Location = new System.Drawing.Point(98, 64);
            this.txtAyudante.Name = "txtAyudante";
            this.txtAyudante.Size = new System.Drawing.Size(215, 21);
            this.txtAyudante.TabIndex = 48;
            this.txtAyudante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.Location = new System.Drawing.Point(23, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ayudante:";
            // 
            // tsbBuscarVia
            // 
            this.tsbBuscarVia.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarVia.Location = new System.Drawing.Point(318, 35);
            this.tsbBuscarVia.Name = "tsbBuscarVia";
            this.tsbBuscarVia.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarVia.TabIndex = 46;
            this.tsbBuscarVia.UseVisualStyleBackColor = true;
            this.tsbBuscarVia.Click += new System.EventHandler(this.tsbBuscarVia_Click);
            // 
            // txtVia
            // 
            this.txtVia.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtVia.Location = new System.Drawing.Point(98, 37);
            this.txtVia.Name = "txtVia";
            this.txtVia.Size = new System.Drawing.Size(215, 21);
            this.txtVia.TabIndex = 45;
            this.txtVia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(59, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Via:";
            // 
            // tpProcedimientos
            // 
            this.tpProcedimientos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProcedimientos.Controls.Add(this.dgvProcedimientos);
            this.tpProcedimientos.Location = new System.Drawing.Point(124, 4);
            this.tpProcedimientos.Name = "tpProcedimientos";
            this.tpProcedimientos.Size = new System.Drawing.Size(769, 345);
            this.tpProcedimientos.TabIndex = 1;
            this.tpProcedimientos.Text = "Procedimientos";
            // 
            // dgvProcedimientos
            // 
            this.dgvProcedimientos.AllowUserToAddRows = false;
            this.dgvProcedimientos.AllowUserToDeleteRows = false;
            this.dgvProcedimientos.AllowUserToResizeColumns = false;
            this.dgvProcedimientos.AllowUserToResizeRows = false;
            this.dgvProcedimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProcedimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProcedimientos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.quitar,
            this.cups,
            this.descripcion,
            this.cantidad,
            this.justificacion});
            this.dgvProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedimientos.Location = new System.Drawing.Point(0, 0);
            this.dgvProcedimientos.MultiSelect = false;
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.ReadOnly = true;
            this.dgvProcedimientos.RowHeadersVisible = false;
            this.dgvProcedimientos.Size = new System.Drawing.Size(769, 345);
            this.dgvProcedimientos.TabIndex = 3;
            this.dgvProcedimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellClick);
            this.dgvProcedimientos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellEndEdit);
            this.dgvProcedimientos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProcedimientos_DataError);
            this.dgvProcedimientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProcedimientos_KeyPress);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Image = Properties.Resources.farmacia_ico;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Agregar.Width = 75;
            // 
            // quitar
            // 
            this.quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quitar.HeaderText = "Quitar";
            this.quitar.Image = Properties.Resources.btn_anular;
            this.quitar.Name = "quitar";
            this.quitar.ReadOnly = true;
            this.quitar.Width = 50;
            // 
            // cups
            // 
            this.cups.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cups.HeaderText = "Código";
            this.cups.Name = "cups";
            this.cups.ReadOnly = true;
            this.cups.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cups.Width = 75;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad.Width = 63;
            // 
            // justificacion
            // 
            this.justificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.justificacion.HeaderText = "Justificación";
            this.justificacion.Name = "justificacion";
            this.justificacion.ReadOnly = true;
            this.justificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.justificacion.Width = 250;
            // 
            // tabMedicamento
            // 
            this.tabMedicamento.Controls.Add(this.dgvMedicamento);
            this.tabMedicamento.Location = new System.Drawing.Point(124, 4);
            this.tabMedicamento.Name = "tabMedicamento";
            this.tabMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicamento.Size = new System.Drawing.Size(769, 345);
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
            this.dgvMedicamento.Size = new System.Drawing.Size(763, 339);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.CantidadMed.DefaultCellStyle = dataGridViewCellStyle2;
            this.CantidadMed.HeaderText = "Cantidad";
            this.CantidadMed.Name = "CantidadMed";
            this.CantidadMed.ReadOnly = true;
            this.CantidadMed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CantidadMed.Width = 63;
            // 
            // InformeQuirurgicoUI
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
            this.Name = "InformeQuirurgicoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeQuirurgicoUI";
            this.Load += new System.EventHandler(this.InformeQuirurgicoUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcOrdenMedica.ResumeLayout(false);
            this.tpDatosQuirurgicos.ResumeLayout(false);
            this.tpDatosQuirurgicos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCaracteristica.ResumeLayout(false);
            this.pnlCaracteristica.PerformLayout();
            this.tpProcedimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.tabMedicamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Button tsbBuscarPaciente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripButton tstImprimir;
        private TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.TabPage tpDatosQuirurgicos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel pnlCaracteristica;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button tsbBuscarAnastesia;
        private System.Windows.Forms.TextBox txtAnastesia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button tsbBuscarAnastesiologo;
        private System.Windows.Forms.TextBox txtAnastesiologo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button tsbBuscarAyudante;
        private System.Windows.Forms.TextBox txtAyudante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button tsbBuscarVia;
        private System.Windows.Forms.TextBox txtVia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tpProcedimientos;
        internal System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.DataGridViewImageColumn Agregar;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cups;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificacion;
        private System.Windows.Forms.TabPage tabMedicamento;
        internal System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.DataGridViewImageColumn agregarMed;
        private System.Windows.Forms.DataGridViewImageColumn quitarMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMed;
    }
}