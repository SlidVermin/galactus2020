using Vista.General;

namespace Vista.HistoriaClinica.Enfermeria
{
    partial class PedidoFarmaciaUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPestañas = new TabControlGalactus();
            this.tpMedicamento = new System.Windows.Forms.TabPage();
            this.tpInsumos = new System.Windows.Forms.TabPage();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.label15 = new System.Windows.Forms.Label();
            this.tsbBuscarNit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtAtencion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPedidoMedicamento = new System.Windows.Forms.DataGridView();
            this.dgMedicamentoEnviar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgIdOrdenMedicaPedMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn221 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn222 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn227 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn228 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn229 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvPedidoInsumo = new System.Windows.Forms.DataGridView();
            this.dgInsumoEnviar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgIdOrdenInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn245 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn247 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn248 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPestañas.SuspendLayout();
            this.tpMedicamento.SuspendLayout();
            this.tpInsumos.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(23, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 142);
            this.panel2.TabIndex = 69;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(7, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(197, 20);
            this.label33.TabIndex = 48;
            this.label33.Text = "Información del pedido.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpPedido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.tsbBuscarNit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtServicio);
            this.panel1.Controls.Add(this.txtPaciente);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.txtAtencion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 99);
            this.panel1.TabIndex = 32;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1027, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // tabPestañas
            // 
            this.tabPestañas.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPestañas.Controls.Add(this.tpMedicamento);
            this.tabPestañas.Controls.Add(this.tpInsumos);
            this.tabPestañas.ItemSize = new System.Drawing.Size(30, 120);
            this.tabPestañas.Location = new System.Drawing.Point(23, 186);
            this.tabPestañas.Multiline = true;
            this.tabPestañas.Name = "tabPestañas";
            this.tabPestañas.SelectedIndex = 0;
            this.tabPestañas.Size = new System.Drawing.Size(1009, 341);
            this.tabPestañas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPestañas.TabIndex = 66;
            // 
            // tpMedicamento
            // 
            this.tpMedicamento.Controls.Add(this.dgvPedidoMedicamento);
            this.tpMedicamento.Location = new System.Drawing.Point(124, 4);
            this.tpMedicamento.Name = "tpMedicamento";
            this.tpMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicamento.Size = new System.Drawing.Size(881, 333);
            this.tpMedicamento.TabIndex = 0;
            this.tpMedicamento.Text = "Medicamentos";
            this.tpMedicamento.UseVisualStyleBackColor = true;
            // 
            // tpInsumos
            // 
            this.tpInsumos.Controls.Add(this.dgvPedidoInsumo);
            this.tpInsumos.Location = new System.Drawing.Point(124, 4);
            this.tpInsumos.Name = "tpInsumos";
            this.tpInsumos.Size = new System.Drawing.Size(881, 333);
            this.tpInsumos.TabIndex = 2;
            this.tpInsumos.Text = "Insumos";
            this.tpInsumos.UseVisualStyleBackColor = true;
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tstModificar,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbBuscar,
            this.tsbAnular});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 555);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 65;
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
            // 
            // tsbAnular
            // 
            this.tsbAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAnular.Image = Properties.Resources.btn_anular;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.Location = new System.Drawing.Point(60, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 18);
            this.label15.TabIndex = 64;
            this.label15.Text = "Pedido a farmacia";
            // 
            // tsbBuscarNit
            // 
            this.tsbBuscarNit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscarNit.Image = Properties.Resources.btn_lupa;
            this.tsbBuscarNit.Location = new System.Drawing.Point(237, 32);
            this.tsbBuscarNit.Name = "tsbBuscarNit";
            this.tsbBuscarNit.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarNit.TabIndex = 52;
            this.tsbBuscarNit.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(611, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Entorno:";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(670, 58);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(294, 21);
            this.txtServicio.TabIndex = 50;
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(126, 58);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(456, 21);
            this.txtPaciente.TabIndex = 49;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(387, 34);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(195, 21);
            this.txtIdentificacion.TabIndex = 48;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtencion
            // 
            this.txtAtencion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtencion.Location = new System.Drawing.Point(126, 34);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Size = new System.Drawing.Size(109, 21);
            this.txtAtencion.TabIndex = 47;
            this.txtAtencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Atención:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(126, 8);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(144, 21);
            this.txtCodigo.TabIndex = 54;
            // 
            // dtpPedido
            // 
            this.dtpPedido.CustomFormat = "dd/MM/yyyy HH.mm:ss";
            this.dtpPedido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPedido.Location = new System.Drawing.Point(387, 8);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(144, 21);
            this.dtpPedido.TabIndex = 10028;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 10027;
            this.label1.Text = "Fecha:";
            // 
            // dgvPedidoMedicamento
            // 
            this.dgvPedidoMedicamento.AllowUserToAddRows = false;
            this.dgvPedidoMedicamento.AllowUserToDeleteRows = false;
            this.dgvPedidoMedicamento.AllowUserToResizeColumns = false;
            this.dgvPedidoMedicamento.AllowUserToResizeRows = false;
            this.dgvPedidoMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidoMedicamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidoMedicamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPedidoMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoMedicamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedidoMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgMedicamentoEnviar,
            this.dgIdOrdenMedicaPedMed,
            this.DataGridViewTextBoxColumn221,
            this.DataGridViewTextBoxColumn222,
            this.DataGridViewTextBoxColumn227,
            this.DataGridViewTextBoxColumn228,
            this.DataGridViewTextBoxColumn229,
            this.DataGridViewComboBoxColumn1,
            this.DataGridViewComboBoxColumn2});
            this.dgvPedidoMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidoMedicamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidoMedicamento.Location = new System.Drawing.Point(3, 3);
            this.dgvPedidoMedicamento.MultiSelect = false;
            this.dgvPedidoMedicamento.Name = "dgvPedidoMedicamento";
            this.dgvPedidoMedicamento.RowHeadersVisible = false;
            this.dgvPedidoMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPedidoMedicamento.Size = new System.Drawing.Size(875, 327);
            this.dgvPedidoMedicamento.TabIndex = 16;
            // 
            // dgMedicamentoEnviar
            // 
            this.dgMedicamentoEnviar.DataPropertyName = "enviar";
            this.dgMedicamentoEnviar.Frozen = true;
            this.dgMedicamentoEnviar.HeaderText = "Enviar";
            this.dgMedicamentoEnviar.Name = "dgMedicamentoEnviar";
            this.dgMedicamentoEnviar.Width = 43;
            // 
            // dgIdOrdenMedicaPedMed
            // 
            this.dgIdOrdenMedicaPedMed.DataPropertyName = "idOrdenMedica";
            this.dgIdOrdenMedicaPedMed.Frozen = true;
            this.dgIdOrdenMedicaPedMed.HeaderText = "Orden";
            this.dgIdOrdenMedicaPedMed.Name = "dgIdOrdenMedicaPedMed";
            this.dgIdOrdenMedicaPedMed.Width = 61;
            // 
            // DataGridViewTextBoxColumn221
            // 
            this.DataGridViewTextBoxColumn221.DataPropertyName = "idEquivalencia";
            this.DataGridViewTextBoxColumn221.Frozen = true;
            this.DataGridViewTextBoxColumn221.HeaderText = "idEquivalencia";
            this.DataGridViewTextBoxColumn221.Name = "DataGridViewTextBoxColumn221";
            this.DataGridViewTextBoxColumn221.Visible = false;
            this.DataGridViewTextBoxColumn221.Width = 101;
            // 
            // DataGridViewTextBoxColumn222
            // 
            this.DataGridViewTextBoxColumn222.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn222.DataPropertyName = "Descripción";
            this.DataGridViewTextBoxColumn222.HeaderText = "Descripción";
            this.DataGridViewTextBoxColumn222.Name = "DataGridViewTextBoxColumn222";
            // 
            // DataGridViewTextBoxColumn227
            // 
            this.DataGridViewTextBoxColumn227.DataPropertyName = "Via admin.";
            this.DataGridViewTextBoxColumn227.HeaderText = "Via admin.";
            this.DataGridViewTextBoxColumn227.Name = "DataGridViewTextBoxColumn227";
            this.DataGridViewTextBoxColumn227.Width = 81;
            // 
            // DataGridViewTextBoxColumn228
            // 
            this.DataGridViewTextBoxColumn228.DataPropertyName = "Dosis";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.DataGridViewTextBoxColumn228.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewTextBoxColumn228.HeaderText = "Dosis";
            this.DataGridViewTextBoxColumn228.Name = "DataGridViewTextBoxColumn228";
            this.DataGridViewTextBoxColumn228.Width = 58;
            // 
            // DataGridViewTextBoxColumn229
            // 
            this.DataGridViewTextBoxColumn229.DataPropertyName = "Unidad";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn229.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewTextBoxColumn229.HeaderText = "Unidad";
            this.DataGridViewTextBoxColumn229.Name = "DataGridViewTextBoxColumn229";
            this.DataGridViewTextBoxColumn229.Width = 66;
            // 
            // DataGridViewComboBoxColumn1
            // 
            this.DataGridViewComboBoxColumn1.DataPropertyName = "Horario";
            this.DataGridViewComboBoxColumn1.HeaderText = "Horario";
            this.DataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "Por definir",
            "Cód. Azul",
            "Ahora",
            "Razón nec.",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "36",
            "48",
            "72"});
            this.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1";
            this.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewComboBoxColumn1.Width = 66;
            // 
            // DataGridViewComboBoxColumn2
            // 
            this.DataGridViewComboBoxColumn2.DataPropertyName = "Hora inicial";
            this.DataGridViewComboBoxColumn2.HeaderText = "Hora inicial";
            this.DataGridViewComboBoxColumn2.Items.AddRange(new object[] {
            "Por definir",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2";
            this.DataGridViewComboBoxColumn2.Width = 65;
            // 
            // dgvPedidoInsumo
            // 
            this.dgvPedidoInsumo.AllowUserToAddRows = false;
            this.dgvPedidoInsumo.AllowUserToDeleteRows = false;
            this.dgvPedidoInsumo.AllowUserToResizeColumns = false;
            this.dgvPedidoInsumo.AllowUserToResizeRows = false;
            this.dgvPedidoInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidoInsumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidoInsumo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPedidoInsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoInsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPedidoInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgInsumoEnviar,
            this.dgIdOrdenInsumo,
            this.dgTipoInsumo,
            this.DataGridViewTextBoxColumn245,
            this.DataGridViewTextBoxColumn247,
            this.DataGridViewTextBoxColumn248});
            this.dgvPedidoInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidoInsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidoInsumo.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidoInsumo.MultiSelect = false;
            this.dgvPedidoInsumo.Name = "dgvPedidoInsumo";
            this.dgvPedidoInsumo.RowHeadersVisible = false;
            this.dgvPedidoInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPedidoInsumo.Size = new System.Drawing.Size(881, 333);
            this.dgvPedidoInsumo.TabIndex = 17;
            // 
            // dgInsumoEnviar
            // 
            this.dgInsumoEnviar.DataPropertyName = "enviar";
            this.dgInsumoEnviar.HeaderText = "Enviar";
            this.dgInsumoEnviar.Name = "dgInsumoEnviar";
            this.dgInsumoEnviar.Width = 43;
            // 
            // dgIdOrdenInsumo
            // 
            this.dgIdOrdenInsumo.DataPropertyName = "idOrdenInsumo";
            this.dgIdOrdenInsumo.HeaderText = "Orden";
            this.dgIdOrdenInsumo.Name = "dgIdOrdenInsumo";
            this.dgIdOrdenInsumo.Width = 61;
            // 
            // dgTipoInsumo
            // 
            this.dgTipoInsumo.DataPropertyName = "tipo";
            this.dgTipoInsumo.HeaderText = "Origen";
            this.dgTipoInsumo.Name = "dgTipoInsumo";
            this.dgTipoInsumo.Width = 63;
            // 
            // DataGridViewTextBoxColumn245
            // 
            this.DataGridViewTextBoxColumn245.DataPropertyName = "idEquivalencia";
            this.DataGridViewTextBoxColumn245.HeaderText = "idEquivalencia";
            this.DataGridViewTextBoxColumn245.Name = "DataGridViewTextBoxColumn245";
            this.DataGridViewTextBoxColumn245.Visible = false;
            this.DataGridViewTextBoxColumn245.Width = 101;
            // 
            // DataGridViewTextBoxColumn247
            // 
            this.DataGridViewTextBoxColumn247.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn247.DataPropertyName = "Descripción";
            this.DataGridViewTextBoxColumn247.HeaderText = "Descripción";
            this.DataGridViewTextBoxColumn247.Name = "DataGridViewTextBoxColumn247";
            // 
            // DataGridViewTextBoxColumn248
            // 
            this.DataGridViewTextBoxColumn248.DataPropertyName = "Cantidad";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "0";
            this.DataGridViewTextBoxColumn248.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewTextBoxColumn248.HeaderText = "Cantidad";
            this.DataGridViewTextBoxColumn248.Name = "DataGridViewTextBoxColumn248";
            this.DataGridViewTextBoxColumn248.Width = 74;
            // 
            // PedidoFarmaciaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabPestañas);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1059, 580);
            this.MinimumSize = new System.Drawing.Size(1059, 580);
            this.Name = "PedidoFarmaciaUI";
            this.Text = "PedidoFarmaciaUI";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPestañas.ResumeLayout(false);
            this.tpMedicamento.ResumeLayout(false);
            this.tpInsumos.ResumeLayout(false);
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TabControlGalactus tabPestañas;
        private System.Windows.Forms.TabPage tpMedicamento;
        private System.Windows.Forms.TabPage tpInsumos;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button tsbBuscarNit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtAtencion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.DateTimePicker dtpPedido;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvPedidoMedicamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgMedicamentoEnviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdOrdenMedicaPedMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn221;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn222;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn227;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn228;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn229;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridViewComboBoxColumn2;
        public System.Windows.Forms.DataGridView dgvPedidoInsumo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgInsumoEnviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdOrdenInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn245;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn247;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn248;
    }
}