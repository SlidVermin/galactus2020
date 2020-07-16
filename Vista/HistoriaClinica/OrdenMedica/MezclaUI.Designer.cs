namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class MezclaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MezclaUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMezcla = new System.Windows.Forms.DataGridView();
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.idMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEquivalencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMezcla)).BeginInit();
            this.tstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(722, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dgvMezcla);
            this.GroupBox1.Controls.Add(this.tstMenu);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(6, 30);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(743, 320);
            this.GroupBox1.TabIndex = 68;
            this.GroupBox1.TabStop = false;
            // 
            // dgvMezcla
            // 
            this.dgvMezcla.AllowUserToAddRows = false;
            this.dgvMezcla.AllowUserToDeleteRows = false;
            this.dgvMezcla.AllowUserToResizeColumns = false;
            this.dgvMezcla.AllowUserToResizeRows = false;
            this.dgvMezcla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMezcla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMezcla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMezcla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMezcla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMezcla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMezcla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamento,
            this.idEquivalencia,
            this.Descripcion,
            this.Dosis,
            this.Unidad,
            this.agregar,
            this.quitar});
            this.dgvMezcla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMezcla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMezcla.Location = new System.Drawing.Point(3, 17);
            this.dgvMezcla.MultiSelect = false;
            this.dgvMezcla.Name = "dgvMezcla";
            this.dgvMezcla.RowHeadersVisible = false;
            this.dgvMezcla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMezcla.Size = new System.Drawing.Size(737, 275);
            this.dgvMezcla.TabIndex = 67;
            this.dgvMezcla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMezcla_CellClick);
            this.dgvMezcla.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMezcla_DataError);
            // 
            // tstMenu
            // 
            this.tstMenu.BackColor = System.Drawing.Color.White;
            this.tstMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtGuardar,
            this.tsBtCancelar});
            this.tstMenu.Location = new System.Drawing.Point(3, 292);
            this.tstMenu.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(1095, 25);
            this.tstMenu.TabIndex = 66;
            this.tstMenu.Text = "toolStrip1";
            // 
            // tsBtGuardar
            // 
            this.tsBtGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtGuardar.Image")));
            this.tsBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtGuardar.Name = "tsBtGuardar";
            this.tsBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsBtGuardar.Text = "Guardar";
            this.tsBtGuardar.Click += new System.EventHandler(this.tsBtGuardar_Click);
            // 
            // tsBtCancelar
            // 
            this.tsBtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtCancelar.Image")));
            this.tsBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtCancelar.Name = "tsBtCancelar";
            this.tsBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsBtCancelar.Text = "Cancelar";
            this.tsBtCancelar.Click += new System.EventHandler(this.tsBtCancelar_Click);
            // 
            // idMedicamento
            // 
            this.idMedicamento.DataPropertyName = "idMedicamento";
            this.idMedicamento.HeaderText = "idMedicamento";
            this.idMedicamento.Name = "idMedicamento";
            this.idMedicamento.Visible = false;
            this.idMedicamento.Width = 97;
            // 
            // idEquivalencia
            // 
            this.idEquivalencia.DataPropertyName = "idEquivalencia";
            this.idEquivalencia.HeaderText = "idEquivalencia";
            this.idEquivalencia.Name = "idEquivalencia";
            this.idEquivalencia.Visible = false;
            this.idEquivalencia.Width = 93;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripción";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dosis
            // 
            this.Dosis.DataPropertyName = "Dosis";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Dosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            this.Dosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dosis.Width = 46;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "Unidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Unidad.Width = 53;
            // 
            // agregar
            // 
            this.agregar.HeaderText = "Agregar";
            this.agregar.Image = Properties.Resources.farmacia_ico;
            this.agregar.Name = "agregar";
            this.agregar.ReadOnly = true;
            this.agregar.Width = 56;
            // 
            // quitar
            // 
            this.quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quitar.HeaderText = "Quitar";
            this.quitar.Image = Properties.Resources.btn_anular;
            this.quitar.Name = "quitar";
            this.quitar.ReadOnly = true;
            this.quitar.Width = 46;
            // 
            // MezclaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 353);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(754, 353);
            this.MinimumSize = new System.Drawing.Size(754, 353);
            this.Name = "MezclaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MezclaUI";
            this.Load += new System.EventHandler(this.MezclaUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MezclaUI_KeyDown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMezcla)).EndInit();
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ToolStrip tstMenu;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        public System.Windows.Forms.DataGridView dgvMezcla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquivalencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewImageColumn agregar;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
    }
}