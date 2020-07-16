namespace Vista.HistoriaClinica
{
    partial class ListadoPacienteUI
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pacientePB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListaPaciente = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEntorno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarHCPacienteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNeonatal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaciente)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F);
            this.lbTitulo.Location = new System.Drawing.Point(60, 15);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(136, 18);
            this.lbTitulo.TabIndex = 31;
            this.lbTitulo.Text = "Lista de pacientes";
            // 
            // pacientePB
            // 
            this.pacientePB.Image = Properties.Resources.user__1_;
            this.pacientePB.Location = new System.Drawing.Point(25, 4);
            this.pacientePB.Name = "pacientePB";
            this.pacientePB.Size = new System.Drawing.Size(31, 31);
            this.pacientePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacientePB.TabIndex = 32;
            this.pacientePB.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 571);
            this.panel1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaPaciente);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(7, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 505);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de pacientes (200)";
            // 
            // dgvListaPaciente
            // 
            this.dgvListaPaciente.AllowUserToAddRows = false;
            this.dgvListaPaciente.AllowUserToDeleteRows = false;
            this.dgvListaPaciente.AllowUserToResizeColumns = false;
            this.dgvListaPaciente.AllowUserToResizeRows = false;
            this.dgvListaPaciente.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAtencion,
            this.dgAdmision,
            this.dgPaciente,
            this.dgFechaIngreso,
            this.dgEntorno,
            this.dgArea,
            this.dgEstancia,
            this.dgEdad,
            this.dgGenero,
            this.dgCliente,
            this.dgColor,
            this.dgEgreso,
            this.dgNeonatal});
            this.dgvListaPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaPaciente.Location = new System.Drawing.Point(3, 18);
            this.dgvListaPaciente.Name = "dgvListaPaciente";
            this.dgvListaPaciente.ReadOnly = true;
            this.dgvListaPaciente.RowHeadersVisible = false;
            this.dgvListaPaciente.ShowCellErrors = false;
            this.dgvListaPaciente.ShowCellToolTips = false;
            this.dgvListaPaciente.ShowEditingIcon = false;
            this.dgvListaPaciente.ShowRowErrors = false;
            this.dgvListaPaciente.Size = new System.Drawing.Size(1256, 484);
            this.dgvListaPaciente.TabIndex = 0;
            this.dgvListaPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPaciente_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btLimpiar);
            this.panel2.Controls.Add(this.cbEstado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbEntorno);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buscarHCPacienteBtn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 37);
            this.panel2.TabIndex = 0;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = Properties.Resources.error__1_;
            this.btLimpiar.Location = new System.Drawing.Point(896, 5);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(26, 24);
            this.btLimpiar.TabIndex = 47;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Visible = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(1049, 7);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(198, 21);
            this.cbEstado.TabIndex = 42;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(986, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Estados:";
            // 
            // button1
            // 
            this.button1.Image = Properties.Resources.btn_lupa;
            this.button1.Location = new System.Drawing.Point(928, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(660, 7);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(262, 20);
            this.txtArea.TabIndex = 39;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(617, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Area:";
            // 
            // cbEntorno
            // 
            this.cbEntorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntorno.Enabled = false;
            this.cbEntorno.FormattingEnabled = true;
            this.cbEntorno.Location = new System.Drawing.Point(388, 5);
            this.cbEntorno.Name = "cbEntorno";
            this.cbEntorno.Size = new System.Drawing.Size(212, 21);
            this.cbEntorno.TabIndex = 30;
            this.cbEntorno.SelectedIndexChanged += new System.EventHandler(this.cbEntorno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(325, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Entorno:";
            // 
            // buscarHCPacienteBtn
            // 
            this.buscarHCPacienteBtn.Image = Properties.Resources.btn_lupa;
            this.buscarHCPacienteBtn.Location = new System.Drawing.Point(291, 3);
            this.buscarHCPacienteBtn.Name = "buscarHCPacienteBtn";
            this.buscarHCPacienteBtn.Size = new System.Drawing.Size(26, 24);
            this.buscarHCPacienteBtn.TabIndex = 28;
            this.buscarHCPacienteBtn.UseVisualStyleBackColor = true;
            this.buscarHCPacienteBtn.Click += new System.EventHandler(this.buscarHCPacienteBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1286, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgAtencion
            // 
            this.dgAtencion.HeaderText = "Atencion";
            this.dgAtencion.Name = "dgAtencion";
            this.dgAtencion.ReadOnly = true;
            this.dgAtencion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgAtencion.Width = 65;
            // 
            // dgAdmision
            // 
            this.dgAdmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgAdmision.HeaderText = "Admision";
            this.dgAdmision.Name = "dgAdmision";
            this.dgAdmision.ReadOnly = true;
            this.dgAdmision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgAdmision.Width = 65;
            // 
            // dgPaciente
            // 
            this.dgPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgPaciente.HeaderText = "Paciente";
            this.dgPaciente.Name = "dgPaciente";
            this.dgPaciente.ReadOnly = true;
            this.dgPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgPaciente.Width = 65;
            // 
            // dgFechaIngreso
            // 
            this.dgFechaIngreso.HeaderText = "Fecha Ingreso";
            this.dgFechaIngreso.Name = "dgFechaIngreso";
            this.dgFechaIngreso.ReadOnly = true;
            this.dgFechaIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgEntorno
            // 
            this.dgEntorno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgEntorno.HeaderText = "Entorno";
            this.dgEntorno.Name = "dgEntorno";
            this.dgEntorno.ReadOnly = true;
            this.dgEntorno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgEntorno.Width = 59;
            // 
            // dgArea
            // 
            this.dgArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgArea.HeaderText = "Area";
            this.dgArea.Name = "dgArea";
            this.dgArea.ReadOnly = true;
            this.dgArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgArea.Width = 41;
            // 
            // dgEstancia
            // 
            this.dgEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgEstancia.HeaderText = "Estancia";
            this.dgEstancia.Name = "dgEstancia";
            this.dgEstancia.ReadOnly = true;
            this.dgEstancia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgEstancia.Width = 65;
            // 
            // dgEdad
            // 
            this.dgEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgEdad.HeaderText = "Edad";
            this.dgEdad.Name = "dgEdad";
            this.dgEdad.ReadOnly = true;
            this.dgEdad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgEdad.Width = 44;
            // 
            // dgGenero
            // 
            this.dgGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgGenero.HeaderText = "Genero";
            this.dgGenero.Name = "dgGenero";
            this.dgGenero.ReadOnly = true;
            this.dgGenero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgGenero.Width = 56;
            // 
            // dgCliente
            // 
            this.dgCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCliente.HeaderText = "Cliente";
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgColor
            // 
            this.dgColor.HeaderText = "Color";
            this.dgColor.Name = "dgColor";
            this.dgColor.ReadOnly = true;
            this.dgColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgColor.Visible = false;
            // 
            // dgEgreso
            // 
            this.dgEgreso.HeaderText = "Fecha egreso";
            this.dgEgreso.Name = "dgEgreso";
            this.dgEgreso.ReadOnly = true;
            this.dgEgreso.Visible = false;
            // 
            // dgNeonatal
            // 
            this.dgNeonatal.HeaderText = "EsNeonatal";
            this.dgNeonatal.Name = "dgNeonatal";
            this.dgNeonatal.ReadOnly = true;
            this.dgNeonatal.Visible = false;
            // 
            // ListadoPacienteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 629);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pacientePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1320, 629);
            this.MinimumSize = new System.Drawing.Size(1320, 629);
            this.Name = "ListadoPacienteUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPaciente";
            this.Load += new System.EventHandler(this.ListadoPaciente_Load);
            this.Shown += new System.EventHandler(this.ListadoPacienteUI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaciente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pacientePB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscarHCPacienteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListaPaciente;
        private System.Windows.Forms.ComboBox cbEntorno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNeonatal;
    }
}