namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class ValoracionIngresoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValoracionIngresoUI));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbResumenClinico = new System.Windows.Forms.GroupBox();
            this.txtResumenClinico = new System.Windows.Forms.TextBox();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvImpresionN = new System.Windows.Forms.DataGridView();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcausaexterna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtviaingreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinstitucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutorizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRemision = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivoIngreso = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbResumenClinico.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresionN)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemision)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // gbResumenClinico
            // 
            this.gbResumenClinico.Controls.Add(this.txtResumenClinico);
            this.gbResumenClinico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumenClinico.Location = new System.Drawing.Point(3, 189);
            this.gbResumenClinico.Name = "gbResumenClinico";
            this.gbResumenClinico.Size = new System.Drawing.Size(956, 121);
            this.gbResumenClinico.TabIndex = 10091;
            this.gbResumenClinico.TabStop = false;
            this.gbResumenClinico.Text = "Resumen Clínico:";
            // 
            // txtResumenClinico
            // 
            this.txtResumenClinico.Location = new System.Drawing.Point(3, 24);
            this.txtResumenClinico.Multiline = true;
            this.txtResumenClinico.Name = "txtResumenClinico";
            this.txtResumenClinico.Size = new System.Drawing.Size(947, 84);
            this.txtResumenClinico.TabIndex = 0;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvImpresionN);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(6, 316);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(953, 143);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Impresión Diagnóstica:";
            // 
            // dgvImpresionN
            // 
            this.dgvImpresionN.AllowUserToAddRows = false;
            this.dgvImpresionN.AllowUserToDeleteRows = false;
            this.dgvImpresionN.AllowUserToResizeColumns = false;
            this.dgvImpresionN.AllowUserToResizeRows = false;
            this.dgvImpresionN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImpresionN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImpresionN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvImpresionN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpresionN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgCodigo,
            this.dgDescripcion,
            this.dgAgregar,
            this.dgQuitar});
            this.dgvImpresionN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpresionN.Location = new System.Drawing.Point(3, 17);
            this.dgvImpresionN.MultiSelect = false;
            this.dgvImpresionN.Name = "dgvImpresionN";
            this.dgvImpresionN.ReadOnly = true;
            this.dgvImpresionN.RowHeadersVisible = false;
            this.dgvImpresionN.ShowCellErrors = false;
            this.dgvImpresionN.ShowCellToolTips = false;
            this.dgvImpresionN.ShowEditingIcon = false;
            this.dgvImpresionN.ShowRowErrors = false;
            this.dgvImpresionN.Size = new System.Drawing.Size(947, 123);
            this.dgvImpresionN.TabIndex = 2;
            this.dgvImpresionN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpresionN_CellContentClick);
            this.dgvImpresionN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpresionN_CellDoubleClick);
            this.dgvImpresionN.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvImpresionN_DataError);
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
            this.dgAgregar.Image = global::Galactus.Properties.Resources.farmacia_ico;
            this.dgAgregar.Name = "dgAgregar";
            this.dgAgregar.ReadOnly = true;
            this.dgAgregar.Width = 56;
            // 
            // dgQuitar
            // 
            this.dgQuitar.HeaderText = "Quitar";
            this.dgQuitar.Image = global::Galactus.Properties.Resources.btn_anular;
            this.dgQuitar.Name = "dgQuitar";
            this.dgQuitar.ReadOnly = true;
            this.dgQuitar.Width = 46;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtcausaexterna);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtviaingreso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtinstitucion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAutorizacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Controls.Add(this.gbResumenClinico);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(969, 593);
            this.panel1.MinimumSize = new System.Drawing.Size(969, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 593);
            this.panel1.TabIndex = 0;
            // 
            // txtcausaexterna
            // 
            this.txtcausaexterna.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtcausaexterna.Location = new System.Drawing.Point(530, 34);
            this.txtcausaexterna.Name = "txtcausaexterna";
            this.txtcausaexterna.ReadOnly = true;
            this.txtcausaexterna.Size = new System.Drawing.Size(246, 22);
            this.txtcausaexterna.TabIndex = 10104;
            this.txtcausaexterna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 10103;
            this.label4.Text = "Causa externa:";
            // 
            // txtviaingreso
            // 
            this.txtviaingreso.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtviaingreso.Location = new System.Drawing.Point(111, 33);
            this.txtviaingreso.Name = "txtviaingreso";
            this.txtviaingreso.ReadOnly = true;
            this.txtviaingreso.Size = new System.Drawing.Size(316, 22);
            this.txtviaingreso.TabIndex = 10102;
            this.txtviaingreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 10101;
            this.label3.Text = "Via de ingreso:";
            // 
            // txtcama
            // 
            this.txtcama.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtcama.Location = new System.Drawing.Point(830, 7);
            this.txtcama.Name = "txtcama";
            this.txtcama.ReadOnly = true;
            this.txtcama.Size = new System.Drawing.Size(129, 22);
            this.txtcama.TabIndex = 10100;
            this.txtcama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 10099;
            this.label2.Text = "Cama:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtinstitucion
            // 
            this.txtinstitucion.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtinstitucion.Location = new System.Drawing.Point(296, 7);
            this.txtinstitucion.Name = "txtinstitucion";
            this.txtinstitucion.ReadOnly = true;
            this.txtinstitucion.Size = new System.Drawing.Size(480, 22);
            this.txtinstitucion.TabIndex = 10098;
            this.txtinstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 10097;
            this.label1.Text = "Institución:";
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtAutorizacion.Location = new System.Drawing.Point(112, 7);
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.ReadOnly = true;
            this.txtAutorizacion.Size = new System.Drawing.Size(106, 22);
            this.txtAutorizacion.TabIndex = 10096;
            this.txtAutorizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10095;
            this.label5.Text = "Autorizacion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRemision);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 119);
            this.groupBox2.TabIndex = 10094;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnóstico Remisión:";
            // 
            // dgvRemision
            // 
            this.dgvRemision.AllowUserToAddRows = false;
            this.dgvRemision.AllowUserToDeleteRows = false;
            this.dgvRemision.AllowUserToResizeColumns = false;
            this.dgvRemision.AllowUserToResizeRows = false;
            this.dgvRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRemision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRemision.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRemision.Location = new System.Drawing.Point(3, 17);
            this.dgvRemision.MultiSelect = false;
            this.dgvRemision.Name = "dgvRemision";
            this.dgvRemision.ReadOnly = true;
            this.dgvRemision.RowHeadersVisible = false;
            this.dgvRemision.Size = new System.Drawing.Size(950, 99);
            this.dgvRemision.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivoIngreso);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 118);
            this.groupBox1.TabIndex = 10093;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo  Ingreso";
            // 
            // txtMotivoIngreso
            // 
            this.txtMotivoIngreso.Location = new System.Drawing.Point(3, 24);
            this.txtMotivoIngreso.Multiline = true;
            this.txtMotivoIngreso.Name = "txtMotivoIngreso";
            this.txtMotivoIngreso.Size = new System.Drawing.Size(943, 91);
            this.txtMotivoIngreso.TabIndex = 0;
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtpeso.Location = new System.Drawing.Point(830, 35);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(129, 22);
            this.txtpeso.TabIndex = 10106;
            this.txtpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(782, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10105;
            this.label6.Text = "Peso:";
            // 
            // ValoracionIngresoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(969, 596);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ValoracionIngresoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AtencionIngresoUI";
            this.Load += new System.EventHandler(this.ValoracionIngresoUI_Load);
            this.gbResumenClinico.ResumeLayout(false);
            this.gbResumenClinico.PerformLayout();
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresionN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemision)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox gbResumenClinico;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvImpresionN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtMotivoIngreso;
        internal System.Windows.Forms.TextBox txtResumenClinico;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvRemision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn dgAgregar;
        private System.Windows.Forms.DataGridViewImageColumn dgQuitar;
        internal System.Windows.Forms.TextBox txtcausaexterna;
        internal System.Windows.Forms.TextBox txtviaingreso;
        internal System.Windows.Forms.TextBox txtcama;
        internal System.Windows.Forms.TextBox txtinstitucion;
        internal System.Windows.Forms.TextBox txtAutorizacion;
        internal System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label6;
    }
}