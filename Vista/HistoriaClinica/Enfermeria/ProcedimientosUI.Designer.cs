namespace Vista.HistoriaClinica.Enfermeria
{
    partial class ProcedimientosUI
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
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLista = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgFormato = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvProcedimientos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(5, 8);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 269);
            this.GroupBox17.TabIndex = 10096;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Procedimientos";
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
            this.dgId,
            this.dgCodigo,
            this.dgDescripcion,
            this.dgLista,
            this.dgFormato});
            this.dgvProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedimientos.Location = new System.Drawing.Point(3, 17);
            this.dgvProcedimientos.MultiSelect = false;
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.ReadOnly = true;
            this.dgvProcedimientos.RowHeadersVisible = false;
            this.dgvProcedimientos.ShowCellErrors = false;
            this.dgvProcedimientos.ShowCellToolTips = false;
            this.dgvProcedimientos.ShowEditingIcon = false;
            this.dgvProcedimientos.ShowRowErrors = false;
            this.dgvProcedimientos.Size = new System.Drawing.Size(956, 249);
            this.dgvProcedimientos.TabIndex = 2;
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
            this.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcion.HeaderText = "Descripcion";
            this.dgDescripcion.Name = "dgDescripcion";
            this.dgDescripcion.ReadOnly = true;
            // 
            // dgLista
            // 
            this.dgLista.HeaderText = "Lista";
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.Width = 40;
            // 
            // dgFormato
            // 
            this.dgFormato.HeaderText = "Formato";
            this.dgFormato.Name = "dgFormato";
            this.dgFormato.ReadOnly = true;
            this.dgFormato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFormato.Width = 59;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Agregar";
            this.dataGridViewImageColumn1.Image = Properties.Resources.farmacia_ico;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Quitar";
            this.dataGridViewImageColumn2.Image = Properties.Resources.btn_anular;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 41;
            // 
            // ProcedimientosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 280);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(972, 280);
            this.MinimumSize = new System.Drawing.Size(972, 280);
            this.Name = "ProcedimientosUI";
            this.Text = "HemoderivadosUI";
            this.Load += new System.EventHandler(this.ProcedimientosUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn dgLista;
        private System.Windows.Forms.DataGridViewButtonColumn dgFormato;
    }
}