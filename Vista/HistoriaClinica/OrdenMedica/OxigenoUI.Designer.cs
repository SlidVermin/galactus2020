namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class OxigenoUI
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
            this.dgvOrdenOxigeno = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgIdOxigenoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionOrdenOxigeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSuspenderOxigenoOrden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgObservacionOxigeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenOxigeno)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvOrdenOxigeno);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 154);
            this.GroupBox17.TabIndex = 10093;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Oxigeno ";
            // 
            // dgvOrdenOxigeno
            // 
            this.dgvOrdenOxigeno.AllowUserToAddRows = false;
            this.dgvOrdenOxigeno.AllowUserToDeleteRows = false;
            this.dgvOrdenOxigeno.AllowUserToResizeColumns = false;
            this.dgvOrdenOxigeno.AllowUserToResizeRows = false;
            this.dgvOrdenOxigeno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenOxigeno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenOxigeno.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrdenOxigeno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenOxigeno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenOxigeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenOxigeno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agregar,
            this.quitar,
            this.dgIdOxigenoOrden,
            this.dgDescripcionOrdenOxigeno,
            this.dgSuspenderOxigenoOrden,
            this.dgObservacionOxigeno});
            this.dgvOrdenOxigeno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdenOxigeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenOxigeno.Location = new System.Drawing.Point(3, 17);
            this.dgvOrdenOxigeno.MultiSelect = false;
            this.dgvOrdenOxigeno.Name = "dgvOrdenOxigeno";
            this.dgvOrdenOxigeno.ReadOnly = true;
            this.dgvOrdenOxigeno.RowHeadersVisible = false;
            this.dgvOrdenOxigeno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenOxigeno.Size = new System.Drawing.Size(956, 134);
            this.dgvOrdenOxigeno.TabIndex = 15;
            this.dgvOrdenOxigeno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenOxigeno_CellClick);
            this.dgvOrdenOxigeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvOrdenOxigeno_KeyPress);
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
            // dgIdOxigenoOrden
            // 
            this.dgIdOxigenoOrden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgIdOxigenoOrden.DataPropertyName = "idOxigeno";
            this.dgIdOxigenoOrden.HeaderText = "idOxigeno";
            this.dgIdOxigenoOrden.Name = "dgIdOxigenoOrden";
            this.dgIdOxigenoOrden.ReadOnly = true;
            this.dgIdOxigenoOrden.Visible = false;
            this.dgIdOxigenoOrden.Width = 609;
            // 
            // dgDescripcionOrdenOxigeno
            // 
            this.dgDescripcionOrdenOxigeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcionOrdenOxigeno.DataPropertyName = "Descripción";
            this.dgDescripcionOrdenOxigeno.HeaderText = "Descripción";
            this.dgDescripcionOrdenOxigeno.Name = "dgDescripcionOrdenOxigeno";
            this.dgDescripcionOrdenOxigeno.ReadOnly = true;
            this.dgDescripcionOrdenOxigeno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgSuspenderOxigenoOrden
            // 
            this.dgSuspenderOxigenoOrden.DataPropertyName = "Suspender";
            this.dgSuspenderOxigenoOrden.HeaderText = "Suspender";
            this.dgSuspenderOxigenoOrden.Name = "dgSuspenderOxigenoOrden";
            this.dgSuspenderOxigenoOrden.ReadOnly = true;
            this.dgSuspenderOxigenoOrden.Width = 74;
            // 
            // dgObservacionOxigeno
            // 
            this.dgObservacionOxigeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgObservacionOxigeno.DataPropertyName = "Observación";
            this.dgObservacionOxigeno.HeaderText = "Observación";
            this.dgObservacionOxigeno.Name = "dgObservacionOxigeno";
            this.dgObservacionOxigeno.ReadOnly = true;
            this.dgObservacionOxigeno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgObservacionOxigeno.Width = 250;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Mezcla";
            this.dataGridViewImageColumn1.Image = Properties.Resources.infusion16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Agregar";
            this.dataGridViewImageColumn2.Image = Properties.Resources.farmacia_ico;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Quitar";
            this.dataGridViewImageColumn3.Image = Properties.Resources.btn_anular;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // OxigenoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "OxigenoUI";
            this.Text = "OxigenoUI";
            this.Load += new System.EventHandler(this.OxigenoUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenOxigeno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        public System.Windows.Forms.DataGridView dgvOrdenOxigeno;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn agregar;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdOxigenoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionOrdenOxigeno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSuspenderOxigenoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgObservacionOxigeno;
    }
}