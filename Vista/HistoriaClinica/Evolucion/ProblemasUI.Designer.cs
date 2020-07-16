namespace Vista.HistoriaClinica.Evolucion
{
    partial class ProblemasUI
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
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvDiagnostico = new System.Windows.Forms.DataGridView();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSubjetivos = new System.Windows.Forms.RichTextBox();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvDiagnostico);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F);
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(5, 7);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(952, 156);
            this.GroupBox17.TabIndex = 10093;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Diagnósticos:";
            // 
            // dgvDiagnostico
            // 
            this.dgvDiagnostico.AllowUserToAddRows = false;
            this.dgvDiagnostico.AllowUserToDeleteRows = false;
            this.dgvDiagnostico.AllowUserToResizeColumns = false;
            this.dgvDiagnostico.AllowUserToResizeRows = false;
            this.dgvDiagnostico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDiagnostico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDiagnostico.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgCodigo,
            this.dgDescripcion,
            this.dgAgregar,
            this.dgQuitar});
            this.dgvDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiagnostico.Location = new System.Drawing.Point(3, 17);
            this.dgvDiagnostico.MultiSelect = false;
            this.dgvDiagnostico.Name = "dgvDiagnostico";
            this.dgvDiagnostico.ReadOnly = true;
            this.dgvDiagnostico.RowHeadersVisible = false;
            this.dgvDiagnostico.ShowCellErrors = false;
            this.dgvDiagnostico.ShowCellToolTips = false;
            this.dgvDiagnostico.ShowEditingIcon = false;
            this.dgvDiagnostico.ShowRowErrors = false;
            this.dgvDiagnostico.Size = new System.Drawing.Size(946, 136);
            this.dgvDiagnostico.TabIndex = 2;
            this.dgvDiagnostico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnostico_CellContentClick);
            // 
            // dgId
            // 
            this.dgId.HeaderText = "Id";
            this.dgId.Name = "dgId";
            this.dgId.ReadOnly = true;
            this.dgId.Visible = false;
            this.dgId.Width = 26;
            // 
            // dgCodigo
            // 
            this.dgCodigo.HeaderText = "Código";
            this.dgCodigo.Name = "dgCodigo";
            this.dgCodigo.ReadOnly = true;
            this.dgCodigo.Width = 72;
            // 
            // dgDescripcion
            // 
            this.dgDescripcion.HeaderText = "Descripcion";
            this.dgDescripcion.Name = "dgDescripcion";
            this.dgDescripcion.ReadOnly = true;
            this.dgDescripcion.Width = 98;
            // 
            // dgAgregar
            // 
            this.dgAgregar.HeaderText = "Agregar";
            this.dgAgregar.Image = Properties.Resources.farmacia_ico;
            this.dgAgregar.Name = "dgAgregar";
            this.dgAgregar.ReadOnly = true;
            this.dgAgregar.Width = 56;
            // 
            // dgQuitar
            // 
            this.dgQuitar.HeaderText = "Quitar";
            this.dgQuitar.Image = Properties.Resources.btn_anular;
            this.dgQuitar.Name = "dgQuitar";
            this.dgQuitar.ReadOnly = true;
            this.dgQuitar.Width = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubjetivos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox1.Location = new System.Drawing.Point(5, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 111);
            this.groupBox1.TabIndex = 10094;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subjetivos";
            // 
            // txtSubjetivos
            // 
            this.txtSubjetivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubjetivos.Location = new System.Drawing.Point(3, 17);
            this.txtSubjetivos.Name = "txtSubjetivos";
            this.txtSubjetivos.Size = new System.Drawing.Size(946, 91);
            this.txtSubjetivos.TabIndex = 0;
            this.txtSubjetivos.Text = "";
            // 
            // ProblemasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(969, 291);
            this.MinimumSize = new System.Drawing.Size(969, 291);
            this.Name = "ProblemasUI";
            this.Text = "ProblemasUI";
            this.Load += new System.EventHandler(this.ProblemasUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn dgAgregar;
        private System.Windows.Forms.DataGridViewImageColumn dgQuitar;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RichTextBox txtSubjetivos;
    }
}