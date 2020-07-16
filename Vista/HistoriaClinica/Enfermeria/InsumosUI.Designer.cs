namespace Vista.HistoriaClinica.Enfermeria
{
    partial class InsumosUI
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
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvInsumos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(5, 5);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(955, 272);
            this.GroupBox17.TabIndex = 10094;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Insumos";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.AllowUserToResizeColumns = false;
            this.dgvInsumos.AllowUserToResizeRows = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInsumos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgCodigo,
            this.dgDescripcion,
            this.dgCantidad,
            this.dgAgregar,
            this.dgQuitar});
            this.dgvInsumos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsumos.Location = new System.Drawing.Point(3, 17);
            this.dgvInsumos.MultiSelect = false;
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.RowHeadersVisible = false;
            this.dgvInsumos.ShowCellErrors = false;
            this.dgvInsumos.ShowCellToolTips = false;
            this.dgvInsumos.ShowEditingIcon = false;
            this.dgvInsumos.ShowRowErrors = false;
            this.dgvInsumos.Size = new System.Drawing.Size(949, 252);
            this.dgvInsumos.TabIndex = 2;
            this.dgvInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellContentClick);
            // 
            // dgId
            // 
            this.dgId.HeaderText = "Id";
            this.dgId.Name = "dgId";
            this.dgId.ReadOnly = true;
            this.dgId.Visible = false;
            this.dgId.Width = 23;
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
            // dgCantidad
            // 
            this.dgCantidad.HeaderText = "Cantidad";
            this.dgCantidad.Name = "dgCantidad";
            this.dgCantidad.ReadOnly = true;
            this.dgCantidad.Width = 82;
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
            // InsumosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 280);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(972, 280);
            this.MinimumSize = new System.Drawing.Size(972, 280);
            this.Name = "InsumosUI";
            this.Text = "InsumosUI";
            this.Load += new System.EventHandler(this.InsumosUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCantidad;
        private System.Windows.Forms.DataGridViewImageColumn dgAgregar;
        private System.Windows.Forms.DataGridViewImageColumn dgQuitar;
    }
}