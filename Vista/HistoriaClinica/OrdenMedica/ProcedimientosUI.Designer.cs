namespace Vista.HistoriaClinica.OrdenMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcedimientosUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 291);
            this.panel1.TabIndex = 1;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvProcedimientos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 276);
            this.GroupBox17.TabIndex = 10092;
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
            this.Agregar,
            this.quitar,
            this.cups,
            this.descripcion,
            this.cantidad,
            this.justificacion});
            this.dgvProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedimientos.Location = new System.Drawing.Point(3, 17);
            this.dgvProcedimientos.MultiSelect = false;
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.ReadOnly = true;
            this.dgvProcedimientos.RowHeadersVisible = false;
            this.dgvProcedimientos.Size = new System.Drawing.Size(956, 256);
            this.dgvProcedimientos.TabIndex = 2;
            this.dgvProcedimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellClick);
            this.dgvProcedimientos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellEndEdit);
            this.dgvProcedimientos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProcedimientos_DataError);
            this.dgvProcedimientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProcedimientos_KeyPress);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
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
            // ProcedimientosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "ProcedimientosUI";
            this.Text = "ProcedimientosUI";
            this.Load += new System.EventHandler(this.ProcedimientosUI_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.DataGridViewImageColumn Agregar;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cups;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificacion;
    }
}