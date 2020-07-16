namespace Vista.HistoriaClinica.Fisioterapia
{
    partial class HojaOxigenoUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvOxigeno = new System.Windows.Forms.DataGridView();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFisioterapeuta = new System.Windows.Forms.TextBox();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOxigeno)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvOxigeno);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(30, 45);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(1228, 389);
            this.GroupBox17.TabIndex = 10095;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Hoja de oxígeno";
            // 
            // dgvOxigeno
            // 
            this.dgvOxigeno.AllowUserToAddRows = false;
            this.dgvOxigeno.AllowUserToDeleteRows = false;
            this.dgvOxigeno.AllowUserToResizeColumns = false;
            this.dgvOxigeno.AllowUserToResizeRows = false;
            this.dgvOxigeno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOxigeno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOxigeno.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOxigeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOxigeno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inicio,
            this.Fin,
            this.Descripcion,
            this.Minutos,
            this.Litros});
            this.dgvOxigeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOxigeno.Location = new System.Drawing.Point(3, 17);
            this.dgvOxigeno.MultiSelect = false;
            this.dgvOxigeno.Name = "dgvOxigeno";
            this.dgvOxigeno.ReadOnly = true;
            this.dgvOxigeno.RowHeadersVisible = false;
            this.dgvOxigeno.ShowCellErrors = false;
            this.dgvOxigeno.ShowCellToolTips = false;
            this.dgvOxigeno.ShowEditingIcon = false;
            this.dgvOxigeno.ShowRowErrors = false;
            this.dgvOxigeno.Size = new System.Drawing.Size(1222, 369);
            this.dgvOxigeno.TabIndex = 2;
            // 
            // Inicio
            // 
            this.Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Inicio.DataPropertyName = "Inicio";
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            this.Inicio.Width = 120;
            // 
            // Fin
            // 
            this.Fin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fin.DataPropertyName = "Fin";
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            this.Fin.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripción";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Minutos
            // 
            this.Minutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Minutos.DataPropertyName = "Minutos";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            this.Minutos.DefaultCellStyle = dataGridViewCellStyle17;
            this.Minutos.HeaderText = "Minutos";
            this.Minutos.Name = "Minutos";
            this.Minutos.ReadOnly = true;
            this.Minutos.Width = 120;
            // 
            // Litros
            // 
            this.Litros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Litros.DataPropertyName = "Litros";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            this.Litros.DefaultCellStyle = dataGridViewCellStyle18;
            this.Litros.HeaderText = "Litros";
            this.Litros.Name = "Litros";
            this.Litros.ReadOnly = true;
            this.Litros.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Litros.Width = 130;
            // 
            // btBuscarUsuario
            // 
            this.btBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBuscarUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarUsuario.Image = Properties.Resources.btn_lupa;
            this.btBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBuscarUsuario.Location = new System.Drawing.Point(960, 9);
            this.btBuscarUsuario.Name = "btBuscarUsuario";
            this.btBuscarUsuario.Size = new System.Drawing.Size(113, 30);
            this.btBuscarUsuario.TabIndex = 10098;
            this.btBuscarUsuario.Text = "Cambiar";
            this.btBuscarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 10096;
            this.label5.Text = "Coordinador de fisioterapia:";
            // 
            // txtFisioterapeuta
            // 
            this.txtFisioterapeuta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFisioterapeuta.Location = new System.Drawing.Point(551, 14);
            this.txtFisioterapeuta.Name = "txtFisioterapeuta";
            this.txtFisioterapeuta.ReadOnly = true;
            this.txtFisioterapeuta.Size = new System.Drawing.Size(404, 21);
            this.txtFisioterapeuta.TabIndex = 10097;
            // 
            // HojaOxigenoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 455);
            this.Controls.Add(this.btBuscarUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFisioterapeuta);
            this.Controls.Add(this.GroupBox17);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1269, 455);
            this.MinimumSize = new System.Drawing.Size(1269, 455);
            this.Name = "HojaOxigenoUI";
            this.Text = "HojaOxigenoUI";
            this.Load += new System.EventHandler(this.HojaOxigenoUI_Load);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOxigeno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgvOxigeno;
        public System.Windows.Forms.GroupBox GroupBox17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litros;
        private System.Windows.Forms.Button btBuscarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFisioterapeuta;
    }
}