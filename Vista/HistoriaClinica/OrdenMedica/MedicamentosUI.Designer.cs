namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class MedicamentosUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentosUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvOrdenMedicamentos = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEquivalencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdObjetoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnidadOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HoraInicial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgDiasTratamientoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suspender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 291);
            this.panel1.TabIndex = 2;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvOrdenMedicamentos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 285);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Medicamentos";
            // 
            // dgvOrdenMedicamentos
            // 
            this.dgvOrdenMedicamentos.AllowUserToAddRows = false;
            this.dgvOrdenMedicamentos.AllowUserToDeleteRows = false;
            this.dgvOrdenMedicamentos.AllowUserToResizeColumns = false;
            this.dgvOrdenMedicamentos.AllowUserToResizeRows = false;
            this.dgvOrdenMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenMedicamentos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrdenMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamento,
            this.idEquivalencia,
            this.dgDescripcionOrdenMedicamento,
            this.dgTipoOrdenMedicamento,
            this.dgIdObjetoOrdenMedicamento,
            this.viaAdmin,
            this.Dosis,
            this.dgUnidadOrdenMedicamento,
            this.Horario,
            this.HoraInicial,
            this.dgDiasTratamientoOrdenMedicamento,
            this.Suspender,
            this.agregar,
            this.quitar});
            this.dgvOrdenMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdenMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenMedicamentos.Location = new System.Drawing.Point(3, 17);
            this.dgvOrdenMedicamentos.MultiSelect = false;
            this.dgvOrdenMedicamentos.Name = "dgvOrdenMedicamentos";
            this.dgvOrdenMedicamentos.ReadOnly = true;
            this.dgvOrdenMedicamentos.RowHeadersVisible = false;
            this.dgvOrdenMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenMedicamentos.Size = new System.Drawing.Size(956, 265);
            this.dgvOrdenMedicamentos.TabIndex = 15;
            this.dgvOrdenMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenMedicamentos_CellClick);
            this.dgvOrdenMedicamentos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOrdenMedicamentos_DataError);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Agregar";
            this.dataGridViewImageColumn2.Image = Properties.Resources.add;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Quitar";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // idMedicamento
            // 
            this.idMedicamento.DataPropertyName = "idMedicamento";
            this.idMedicamento.HeaderText = "idMedicamento";
            this.idMedicamento.Name = "idMedicamento";
            this.idMedicamento.ReadOnly = true;
            this.idMedicamento.Visible = false;
            this.idMedicamento.Width = 97;
            // 
            // idEquivalencia
            // 
            this.idEquivalencia.DataPropertyName = "idEquivalencia";
            this.idEquivalencia.HeaderText = "idEquivalencia";
            this.idEquivalencia.Name = "idEquivalencia";
            this.idEquivalencia.ReadOnly = true;
            this.idEquivalencia.Visible = false;
            this.idEquivalencia.Width = 93;
            // 
            // dgDescripcionOrdenMedicamento
            // 
            this.dgDescripcionOrdenMedicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcionOrdenMedicamento.DataPropertyName = "Descripción";
            this.dgDescripcionOrdenMedicamento.HeaderText = "Descripción";
            this.dgDescripcionOrdenMedicamento.Name = "dgDescripcionOrdenMedicamento";
            this.dgDescripcionOrdenMedicamento.ReadOnly = true;
            this.dgDescripcionOrdenMedicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgTipoOrdenMedicamento
            // 
            this.dgTipoOrdenMedicamento.DataPropertyName = "tipoMedicamento";
            this.dgTipoOrdenMedicamento.HeaderText = "Tipo";
            this.dgTipoOrdenMedicamento.Name = "dgTipoOrdenMedicamento";
            this.dgTipoOrdenMedicamento.ReadOnly = true;
            this.dgTipoOrdenMedicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgTipoOrdenMedicamento.Visible = false;
            this.dgTipoOrdenMedicamento.Width = 37;
            // 
            // dgIdObjetoOrdenMedicamento
            // 
            this.dgIdObjetoOrdenMedicamento.DataPropertyName = "idObjeto";
            this.dgIdObjetoOrdenMedicamento.HeaderText = "idObjeto";
            this.dgIdObjetoOrdenMedicamento.Name = "dgIdObjetoOrdenMedicamento";
            this.dgIdObjetoOrdenMedicamento.ReadOnly = true;
            this.dgIdObjetoOrdenMedicamento.Visible = false;
            this.dgIdObjetoOrdenMedicamento.Width = 78;
            // 
            // viaAdmin
            // 
            this.viaAdmin.DataPropertyName = "Via admin.";
            this.viaAdmin.HeaderText = "Via admin.";
            this.viaAdmin.Name = "viaAdmin";
            this.viaAdmin.ReadOnly = true;
            this.viaAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.viaAdmin.Width = 71;
            // 
            // Dosis
            // 
            this.Dosis.DataPropertyName = "Dosis";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Dosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MaxInputLength = 8;
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            this.Dosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dosis.Width = 46;
            // 
            // dgUnidadOrdenMedicamento
            // 
            this.dgUnidadOrdenMedicamento.DataPropertyName = "Unidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUnidadOrdenMedicamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUnidadOrdenMedicamento.HeaderText = "Unidad";
            this.dgUnidadOrdenMedicamento.Name = "dgUnidadOrdenMedicamento";
            this.dgUnidadOrdenMedicamento.ReadOnly = true;
            this.dgUnidadOrdenMedicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgUnidadOrdenMedicamento.Width = 53;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Items.AddRange(new object[] {
            "Por definir",
            "Cód. Azul",
            "Ahora",
            "Razón nec.",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "36",
            "48",
            "72"});
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Horario.Width = 54;
            // 
            // HoraInicial
            // 
            this.HoraInicial.DataPropertyName = "Hora inicial";
            this.HoraInicial.HeaderText = "Hora inicial";
            this.HoraInicial.Items.AddRange(new object[] {
            "Por definir",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoraInicial.Name = "HoraInicial";
            this.HoraInicial.ReadOnly = true;
            this.HoraInicial.Width = 75;
            // 
            // dgDiasTratamientoOrdenMedicamento
            // 
            this.dgDiasTratamientoOrdenMedicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgDiasTratamientoOrdenMedicamento.DataPropertyName = "Dias Tto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDiasTratamientoOrdenMedicamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDiasTratamientoOrdenMedicamento.HeaderText = "Dias Tto";
            this.dgDiasTratamientoOrdenMedicamento.Name = "dgDiasTratamientoOrdenMedicamento";
            this.dgDiasTratamientoOrdenMedicamento.ReadOnly = true;
            this.dgDiasTratamientoOrdenMedicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgDiasTratamientoOrdenMedicamento.Width = 70;
            // 
            // Suspender
            // 
            this.Suspender.DataPropertyName = "Suspender";
            this.Suspender.HeaderText = "Suspender";
            this.Suspender.Name = "Suspender";
            this.Suspender.ReadOnly = true;
            this.Suspender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Suspender.Width = 74;
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
            // MedicamentosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "MedicamentosUI";
            this.Text = "MedicamentosUI";
            this.Load += new System.EventHandler(this.MedicamentosUI_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenMedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        public System.Windows.Forms.DataGridView dgvOrdenMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquivalencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdObjetoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnidadOrdenMedicamento;
        private System.Windows.Forms.DataGridViewComboBoxColumn Horario;
        private System.Windows.Forms.DataGridViewComboBoxColumn HoraInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDiasTratamientoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Suspender;
        private System.Windows.Forms.DataGridViewImageColumn agregar;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
    }
}