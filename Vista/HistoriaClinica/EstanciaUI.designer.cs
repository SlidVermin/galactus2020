namespace Vista.HistoriaClinica
{
    partial class EstanciaUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstanciaUI));
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.gbEstancia = new System.Windows.Forms.GroupBox();
            this.dgvEstancia = new System.Windows.Forms.DataGridView();
            this.dgIdCodigoManualCUPSEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgExcluirEstancia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgAsignar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgFechaEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigoCUPSEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJustificacionEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdUsuarioCEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsBtImprimir = new System.Windows.Forms.ToolStripButton();
            this.tstMenu.SuspendLayout();
            this.gbEstancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstancia)).BeginInit();
            this.SuspendLayout();
            // 
            // tstMenu
            // 
            this.tstMenu.BackColor = System.Drawing.Color.White;
            this.tstMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtModificar,
            this.tsBtGuardar,
            this.tsBtCancelar,
            this.tsBtImprimir});
            this.tstMenu.Location = new System.Drawing.Point(0, 332);
            this.tstMenu.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(1095, 25);
            this.tstMenu.TabIndex = 65;
            this.tstMenu.Text = "toolStrip1";
            // 
            // gbEstancia
            // 
            this.gbEstancia.Controls.Add(this.dgvEstancia);
            this.gbEstancia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstancia.Location = new System.Drawing.Point(12, 12);
            this.gbEstancia.Name = "gbEstancia";
            this.gbEstancia.Size = new System.Drawing.Size(1076, 317);
            this.gbEstancia.TabIndex = 66;
            this.gbEstancia.TabStop = false;
            this.gbEstancia.Text = "Listado de estancia por dia";
            // 
            // dgvEstancia
            // 
            this.dgvEstancia.AllowUserToAddRows = false;
            this.dgvEstancia.AllowUserToDeleteRows = false;
            this.dgvEstancia.AllowUserToResizeColumns = false;
            this.dgvEstancia.AllowUserToResizeRows = false;
            this.dgvEstancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstancia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstancia.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEstancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstancia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdCodigoManualCUPSEstancia,
            this.dgExcluirEstancia,
            this.dgAsignar,
            this.dgFechaEstancia,
            this.dgCodigoCUPSEstancia,
            this.dgDescripcionEstancia,
            this.dgJustificacionEstancia,
            this.dgIdUsuarioCEstancia});
            this.dgvEstancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEstancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstancia.Location = new System.Drawing.Point(3, 17);
            this.dgvEstancia.MultiSelect = false;
            this.dgvEstancia.Name = "dgvEstancia";
            this.dgvEstancia.RowHeadersVisible = false;
            this.dgvEstancia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstancia.Size = new System.Drawing.Size(1070, 297);
            this.dgvEstancia.TabIndex = 15;
            this.dgvEstancia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstancia_CellClick);
            this.dgvEstancia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstancia_CellContentClick);
            this.dgvEstancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvEstancia_KeyPress);
            // 
            // dgIdCodigoManualCUPSEstancia
            // 
            this.dgIdCodigoManualCUPSEstancia.DataPropertyName = "idProcedimiento";
            this.dgIdCodigoManualCUPSEstancia.HeaderText = "idProcedimiento";
            this.dgIdCodigoManualCUPSEstancia.Name = "dgIdCodigoManualCUPSEstancia";
            this.dgIdCodigoManualCUPSEstancia.Visible = false;
            this.dgIdCodigoManualCUPSEstancia.Width = 103;
            // 
            // dgExcluirEstancia
            // 
            this.dgExcluirEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgExcluirEstancia.DataPropertyName = "Excluir";
            this.dgExcluirEstancia.HeaderText = "Excluir";
            this.dgExcluirEstancia.Name = "dgExcluirEstancia";
            this.dgExcluirEstancia.ReadOnly = true;
            this.dgExcluirEstancia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExcluirEstancia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgExcluirEstancia.Width = 50;
            // 
            // dgAsignar
            // 
            this.dgAsignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgAsignar.DataPropertyName = "Asignar";
            this.dgAsignar.HeaderText = "Asignar";
            this.dgAsignar.Name = "dgAsignar";
            this.dgAsignar.ReadOnly = true;
            this.dgAsignar.Width = 75;
            // 
            // dgFechaEstancia
            // 
            this.dgFechaEstancia.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgFechaEstancia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFechaEstancia.HeaderText = "Fecha";
            this.dgFechaEstancia.Name = "dgFechaEstancia";
            this.dgFechaEstancia.ReadOnly = true;
            this.dgFechaEstancia.Width = 66;
            // 
            // dgCodigoCUPSEstancia
            // 
            this.dgCodigoCUPSEstancia.DataPropertyName = "Código";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCodigoCUPSEstancia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCodigoCUPSEstancia.HeaderText = "Código";
            this.dgCodigoCUPSEstancia.Name = "dgCodigoCUPSEstancia";
            this.dgCodigoCUPSEstancia.ReadOnly = true;
            this.dgCodigoCUPSEstancia.Width = 72;
            // 
            // dgDescripcionEstancia
            // 
            this.dgDescripcionEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgDescripcionEstancia.DataPropertyName = "descripción";
            this.dgDescripcionEstancia.HeaderText = "Descripción";
            this.dgDescripcionEstancia.Name = "dgDescripcionEstancia";
            this.dgDescripcionEstancia.ReadOnly = true;
            this.dgDescripcionEstancia.Width = 550;
            // 
            // dgJustificacionEstancia
            // 
            this.dgJustificacionEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgJustificacionEstancia.DataPropertyName = "Observación";
            this.dgJustificacionEstancia.HeaderText = "Observación";
            this.dgJustificacionEstancia.Name = "dgJustificacionEstancia";
            this.dgJustificacionEstancia.ReadOnly = true;
            // 
            // dgIdUsuarioCEstancia
            // 
            this.dgIdUsuarioCEstancia.DataPropertyName = "IdUsuarioOrigen";
            this.dgIdUsuarioCEstancia.HeaderText = "idUsuarioOrigen";
            this.dgIdUsuarioCEstancia.Name = "dgIdUsuarioCEstancia";
            this.dgIdUsuarioCEstancia.ReadOnly = true;
            this.dgIdUsuarioCEstancia.Visible = false;
            this.dgIdUsuarioCEstancia.Width = 123;
            // 
            // tsBtModificar
            // 
            this.tsBtModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtModificar.Image")));
            this.tsBtModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtModificar.Name = "tsBtModificar";
            this.tsBtModificar.Size = new System.Drawing.Size(78, 22);
            this.tsBtModificar.Text = "Modificar";
            this.tsBtModificar.Click += new System.EventHandler(this.tsBtModificar_Click);
            // 
            // tsBtGuardar
            // 
            this.tsBtGuardar.Enabled = false;
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
            this.tsBtCancelar.Enabled = false;
            this.tsBtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtCancelar.Image")));
            this.tsBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtCancelar.Name = "tsBtCancelar";
            this.tsBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsBtCancelar.Text = "Cancelar";
            this.tsBtCancelar.Click += new System.EventHandler(this.tsBtCancelar_Click);
            // 
            // tsBtImprimir
            // 
            this.tsBtImprimir.Image = Properties.Resources.print__2_;
            this.tsBtImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtImprimir.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtImprimir.Name = "tsBtImprimir";
            this.tsBtImprimir.Size = new System.Drawing.Size(73, 22);
            this.tsBtImprimir.Text = "Imprimir";
            this.tsBtImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // EstanciaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.gbEstancia);
            this.Controls.Add(this.tstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "EstanciaUI";
            this.Text = "EstanciaUI";
            this.Load += new System.EventHandler(this.EstanciaUI_Load);
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            this.gbEstancia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstMenu;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        internal System.Windows.Forms.GroupBox gbEstancia;
        public System.Windows.Forms.DataGridView dgvEstancia;
        private System.Windows.Forms.ToolStripButton tsBtImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdCodigoManualCUPSEstancia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgExcluirEstancia;
        private System.Windows.Forms.DataGridViewButtonColumn dgAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFechaEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigoCUPSEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJustificacionEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdUsuarioCEstancia;
    }
}