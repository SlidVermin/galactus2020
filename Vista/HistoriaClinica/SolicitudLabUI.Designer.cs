namespace Vista.HistoriaClinica
{
    partial class SolicitudLabUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvResultadoLaboratorio = new System.Windows.Forms.DataGridView();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tstImprimir = new System.Windows.Forms.ToolStripButton();
            this.dgidOrdenMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoLaboratorio)).BeginInit();
            this.pnlInformacion.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlInformacion);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 288);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvResultadoLaboratorio);
            this.panel2.Location = new System.Drawing.Point(15, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 229);
            this.panel2.TabIndex = 53;
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
            this.dgidOrdenMedica,
            this.dgIdProcedimiento,
            this.dgCups,
            this.dgDescripcionProcedimiento,
            this.dgSeleccionar});
            this.dgvResultadoLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvResultadoLaboratorio.Location = new System.Drawing.Point(2, 2);
            this.dgvResultadoLaboratorio.MultiSelect = false;
            this.dgvResultadoLaboratorio.Name = "dgvResultadoLaboratorio";
            this.dgvResultadoLaboratorio.ReadOnly = true;
            this.dgvResultadoLaboratorio.RowHeadersVisible = false;
            this.dgvResultadoLaboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultadoLaboratorio.Size = new System.Drawing.Size(1039, 221);
            this.dgvResultadoLaboratorio.TabIndex = 16;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.dtpFechaSolicitud);
            this.pnlInformacion.Controls.Add(this.label1);
            this.pnlInformacion.Controls.Add(this.cmbLaboratorio);
            this.pnlInformacion.Controls.Add(this.label6);
            this.pnlInformacion.Location = new System.Drawing.Point(15, 10);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(1047, 39);
            this.pnlInformacion.TabIndex = 1;
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaSolicitud.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(942, 8);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaSolicitud.TabIndex = 59;
            this.dtpFechaSolicitud.ValueChanged += new System.EventHandler(this.dtpFechaSolicitud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(845, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Fecha Solicitud:";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratorio.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(88, 6);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(298, 23);
            this.cmbLaboratorio.TabIndex = 52;
            this.cmbLaboratorio.SelectedValueChanged += new System.EventHandler(this.dtpFechaSolicitud_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Laboratorio:";
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbBuscar,
            this.tsbAnular,
            this.tstImprimir});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 304);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 49;
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
            // dgidOrdenMedica
            // 
            this.dgidOrdenMedica.HeaderText = "OrdenMedica";
            this.dgidOrdenMedica.Name = "dgidOrdenMedica";
            this.dgidOrdenMedica.ReadOnly = true;
            this.dgidOrdenMedica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgidOrdenMedica.Width = 86;
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
            // dgCups
            // 
            this.dgCups.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCups.HeaderText = "Cups";
            this.dgCups.Name = "dgCups";
            this.dgCups.ReadOnly = true;
            this.dgCups.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgCups.Width = 43;
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
            // dgSeleccionar
            // 
            this.dgSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSeleccionar.HeaderText = "Enviado";
            this.dgSeleccionar.Name = "dgSeleccionar";
            this.dgSeleccionar.ReadOnly = true;
            this.dgSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SolicitudLabUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 329);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SolicitudLabUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolicitudLabUI";
            this.Load += new System.EventHandler(this.TipoExamenUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoLaboratorio)).EndInit();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvResultadoLaboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.ToolStripButton tstImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidOrdenMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCups;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionProcedimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSeleccionar;
    }
}