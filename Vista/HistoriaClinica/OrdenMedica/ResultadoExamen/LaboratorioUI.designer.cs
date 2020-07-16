namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class LaboratorioUI
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
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvResultadoLaboratorio = new System.Windows.Forms.DataGridView();
            this.dgIdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLectura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoLaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvResultadoLaboratorio);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 282);
            this.GroupBox17.TabIndex = 10093;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Laboratorio";
            // 
            // dgvResultadoLaboratorio
            // 
            this.dgvResultadoLaboratorio.AllowUserToAddRows = false;
            this.dgvResultadoLaboratorio.AllowUserToDeleteRows = false;
            this.dgvResultadoLaboratorio.AllowUserToResizeColumns = false;
            this.dgvResultadoLaboratorio.AllowUserToResizeRows = false;
            this.dgvResultadoLaboratorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultadoLaboratorio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultadoLaboratorio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResultadoLaboratorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadoLaboratorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultadoLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoLaboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdSolicitud,
            this.dgIdProcedimiento,
            this.dgDescripcionProcedimiento,
            this.dgLectura});
            this.dgvResultadoLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvResultadoLaboratorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultadoLaboratorio.Location = new System.Drawing.Point(3, 17);
            this.dgvResultadoLaboratorio.MultiSelect = false;
            this.dgvResultadoLaboratorio.Name = "dgvResultadoLaboratorio";
            this.dgvResultadoLaboratorio.ReadOnly = true;
            this.dgvResultadoLaboratorio.RowHeadersVisible = false;
            this.dgvResultadoLaboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultadoLaboratorio.Size = new System.Drawing.Size(956, 262);
            this.dgvResultadoLaboratorio.TabIndex = 15;
            this.dgvResultadoLaboratorio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadoLaboratorio_CellClick);
            this.dgvResultadoLaboratorio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadoLaboratorio_CellDoubleClick);
            // 
            // dgIdSolicitud
            // 
            this.dgIdSolicitud.HeaderText = "idSolicitud";
            this.dgIdSolicitud.Name = "dgIdSolicitud";
            this.dgIdSolicitud.ReadOnly = true;
            this.dgIdSolicitud.Visible = false;
            this.dgIdSolicitud.Width = 70;
            // 
            // dgIdProcedimiento
            // 
            this.dgIdProcedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgIdProcedimiento.DataPropertyName = "idOxigeno";
            this.dgIdProcedimiento.HeaderText = "idProcedimiento";
            this.dgIdProcedimiento.Name = "dgIdProcedimiento";
            this.dgIdProcedimiento.ReadOnly = true;
            this.dgIdProcedimiento.Visible = false;
            this.dgIdProcedimiento.Width = 609;
            // 
            // dgDescripcionProcedimiento
            // 
            this.dgDescripcionProcedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcionProcedimiento.DataPropertyName = "Descripción";
            this.dgDescripcionProcedimiento.HeaderText = "Descripción";
            this.dgDescripcionProcedimiento.Name = "dgDescripcionProcedimiento";
            this.dgDescripcionProcedimiento.ReadOnly = true;
            this.dgDescripcionProcedimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgLectura
            // 
            this.dgLectura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgLectura.HeaderText = "Lectura";
            this.dgLectura.Name = "dgLectura";
            this.dgLectura.ReadOnly = true;
            this.dgLectura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LaboratorioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "LaboratorioUI";
            this.Text = "LaboratorioUI";
            this.Load += new System.EventHandler(this.LaboratorioUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoLaboratorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        public System.Windows.Forms.DataGridView dgvResultadoLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionProcedimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgLectura;
    }
}