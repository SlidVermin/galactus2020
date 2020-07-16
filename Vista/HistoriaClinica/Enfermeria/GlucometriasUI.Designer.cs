namespace Vista.HistoriaClinica.Enfermeria
{
    partial class GlucometriasUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvGlucometria = new System.Windows.Forms.DataGridView();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGlicemia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInsulina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlucometria)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvGlucometria);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(5, 8);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(955, 270);
            this.GroupBox17.TabIndex = 10097;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Glucometrias";
            // 
            // dgvGlucometria
            // 
            this.dgvGlucometria.AllowUserToAddRows = false;
            this.dgvGlucometria.AllowUserToDeleteRows = false;
            this.dgvGlucometria.AllowUserToResizeColumns = false;
            this.dgvGlucometria.AllowUserToResizeRows = false;
            this.dgvGlucometria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGlucometria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGlucometria.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGlucometria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlucometria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgCodigo,
            this.dgDescripcion,
            this.dgHora,
            this.dgGlicemia,
            this.dgInsulina,
            this.dgResponsable,
            this.dgUsuario});
            this.dgvGlucometria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGlucometria.Location = new System.Drawing.Point(3, 17);
            this.dgvGlucometria.MultiSelect = false;
            this.dgvGlucometria.Name = "dgvGlucometria";
            this.dgvGlucometria.ReadOnly = true;
            this.dgvGlucometria.RowHeadersVisible = false;
            this.dgvGlucometria.ShowCellErrors = false;
            this.dgvGlucometria.ShowCellToolTips = false;
            this.dgvGlucometria.ShowEditingIcon = false;
            this.dgvGlucometria.ShowRowErrors = false;
            this.dgvGlucometria.Size = new System.Drawing.Size(949, 250);
            this.dgvGlucometria.TabIndex = 2;
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
            // dgHora
            // 
            dataGridViewCellStyle4.Format = "T";
            dataGridViewCellStyle4.NullValue = "00:00:00";
            this.dgHora.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgHora.HeaderText = "Hora";
            this.dgHora.Name = "dgHora";
            this.dgHora.ReadOnly = true;
            this.dgHora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHora.Width = 59;
            // 
            // dgGlicemia
            // 
            this.dgGlicemia.HeaderText = "Glicemia";
            this.dgGlicemia.Name = "dgGlicemia";
            this.dgGlicemia.ReadOnly = true;
            this.dgGlicemia.Width = 81;
            // 
            // dgInsulina
            // 
            this.dgInsulina.HeaderText = "Insulina";
            this.dgInsulina.Name = "dgInsulina";
            this.dgInsulina.ReadOnly = true;
            this.dgInsulina.Width = 76;
            // 
            // dgResponsable
            // 
            this.dgResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgResponsable.HeaderText = "Responsable";
            this.dgResponsable.Name = "dgResponsable";
            this.dgResponsable.ReadOnly = true;
            this.dgResponsable.Width = 180;
            // 
            // dgUsuario
            // 
            this.dgUsuario.HeaderText = "Usuario";
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.ReadOnly = true;
            this.dgUsuario.Visible = false;
            this.dgUsuario.Width = 80;
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
            // GlucometriasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 280);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(972, 280);
            this.MinimumSize = new System.Drawing.Size(972, 280);
            this.Name = "GlucometriasUI";
            this.Text = "GlucometriasUI";
            this.Load += new System.EventHandler(this.GlucometriasUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlucometria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvGlucometria;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGlicemia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInsulina;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUsuario;
    }
}