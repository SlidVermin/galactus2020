namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class InfusionImpregnacionUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox63 = new System.Windows.Forms.GroupBox();
            this.dgvOrdenInfusionImpregnacion = new System.Windows.Forms.DataGridView();
            this.IdMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEquivalencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnidadOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEquivalenciaDisolvente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disolvente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCantidadDisolventeOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mezcla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDiasTratamientoOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suspender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgAceptaDisolventeOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox63.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenInfusionImpregnacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Agregar";
            this.dataGridViewImageColumn1.Image = Properties.Resources.farmacia_ico;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 56;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "Quitar";
            this.dataGridViewImageColumn2.Image = Properties.Resources.btn_anular;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 46;
            // 
            // GroupBox63
            // 
            this.GroupBox63.Controls.Add(this.dgvOrdenInfusionImpregnacion);
            this.GroupBox63.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox63.Location = new System.Drawing.Point(12, 3);
            this.GroupBox63.Name = "GroupBox63";
            this.GroupBox63.Size = new System.Drawing.Size(962, 285);
            this.GroupBox63.TabIndex = 8;
            this.GroupBox63.TabStop = false;
            this.GroupBox63.Text = "Infusiones e impregnaciones:";
            // 
            // dgvOrdenInfusionImpregnacion
            // 
            this.dgvOrdenInfusionImpregnacion.AllowUserToAddRows = false;
            this.dgvOrdenInfusionImpregnacion.AllowUserToDeleteRows = false;
            this.dgvOrdenInfusionImpregnacion.AllowUserToResizeColumns = false;
            this.dgvOrdenInfusionImpregnacion.AllowUserToResizeRows = false;
            this.dgvOrdenInfusionImpregnacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenInfusionImpregnacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenInfusionImpregnacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrdenInfusionImpregnacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenInfusionImpregnacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenInfusionImpregnacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenInfusionImpregnacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedicamento,
            this.Tipo,
            this.idEquivalencia,
            this.Descripcion,
            this.tipoMedicamento,
            this.Dosis,
            this.dgUnidadOrdenINIM,
            this.cchora,
            this.idEquivalenciaDisolvente,
            this.Disolvente,
            this.dgCantidadDisolventeOrdenINIM,
            this.HoraInicial,
            this.Mezcla,
            this.dgDiasTratamientoOrdenINIM,
            this.Suspender,
            this.dgAceptaDisolventeOrdenINIM,
            this.agregar,
            this.quitar});
            this.dgvOrdenInfusionImpregnacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdenInfusionImpregnacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenInfusionImpregnacion.Location = new System.Drawing.Point(3, 17);
            this.dgvOrdenInfusionImpregnacion.MultiSelect = false;
            this.dgvOrdenInfusionImpregnacion.Name = "dgvOrdenInfusionImpregnacion";
            this.dgvOrdenInfusionImpregnacion.ReadOnly = true;
            this.dgvOrdenInfusionImpregnacion.RowHeadersVisible = false;
            this.dgvOrdenInfusionImpregnacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenInfusionImpregnacion.Size = new System.Drawing.Size(956, 265);
            this.dgvOrdenInfusionImpregnacion.TabIndex = 15;
            this.dgvOrdenInfusionImpregnacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenInfusionImpregnacion_CellClick);
            this.dgvOrdenInfusionImpregnacion.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOrdenInfusionImpregnacion_DataError);
            this.dgvOrdenInfusionImpregnacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOrdenInfusionImpregnacion_KeyDown);
            // 
            // IdMedicamento
            // 
            this.IdMedicamento.DataPropertyName = "idMedicamento";
            this.IdMedicamento.HeaderText = "idMedicamento";
            this.IdMedicamento.Name = "IdMedicamento";
            this.IdMedicamento.ReadOnly = true;
            this.IdMedicamento.Visible = false;
            this.IdMedicamento.Width = 97;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tipo.Width = 37;
            // 
            // idEquivalencia
            // 
            this.idEquivalencia.DataPropertyName = "idEquivalencia";
            this.idEquivalencia.HeaderText = "idEquivalencia";
            this.idEquivalencia.Name = "idEquivalencia";
            this.idEquivalencia.ReadOnly = true;
            this.idEquivalencia.Visible = false;
            this.idEquivalencia.Width = 112;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.DataPropertyName = "Descripción";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 79;
            // 
            // tipoMedicamento
            // 
            this.tipoMedicamento.DataPropertyName = "tipoMedicamento";
            this.tipoMedicamento.HeaderText = "tipoMedicamento";
            this.tipoMedicamento.Name = "tipoMedicamento";
            this.tipoMedicamento.ReadOnly = true;
            this.tipoMedicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipoMedicamento.Visible = false;
            this.tipoMedicamento.Width = 107;
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
            // dgUnidadOrdenINIM
            // 
            this.dgUnidadOrdenINIM.DataPropertyName = "Unidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUnidadOrdenINIM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUnidadOrdenINIM.HeaderText = "Unidad";
            this.dgUnidadOrdenINIM.Name = "dgUnidadOrdenINIM";
            this.dgUnidadOrdenINIM.ReadOnly = true;
            this.dgUnidadOrdenINIM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgUnidadOrdenINIM.Width = 53;
            // 
            // cchora
            // 
            this.cchora.DataPropertyName = "cc/hora";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.cchora.DefaultCellStyle = dataGridViewCellStyle4;
            this.cchora.HeaderText = "cc/hora";
            this.cchora.MaxInputLength = 8;
            this.cchora.Name = "cchora";
            this.cchora.ReadOnly = true;
            this.cchora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cchora.Width = 53;
            // 
            // idEquivalenciaDisolvente
            // 
            this.idEquivalenciaDisolvente.DataPropertyName = "idEquivalenciaDisolvente";
            this.idEquivalenciaDisolvente.HeaderText = "idEquivalenciaDosilvente";
            this.idEquivalenciaDisolvente.Name = "idEquivalenciaDisolvente";
            this.idEquivalenciaDisolvente.ReadOnly = true;
            this.idEquivalenciaDisolvente.Visible = false;
            this.idEquivalenciaDisolvente.Width = 170;
            // 
            // Disolvente
            // 
            this.Disolvente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Disolvente.DataPropertyName = "Disolvente";
            this.Disolvente.HeaderText = "Disolvente";
            this.Disolvente.MaxInputLength = 5;
            this.Disolvente.Name = "Disolvente";
            this.Disolvente.ReadOnly = true;
            this.Disolvente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Disolvente.Width = 71;
            // 
            // dgCantidadDisolventeOrdenINIM
            // 
            this.dgCantidadDisolventeOrdenINIM.DataPropertyName = "Cantidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.dgCantidadDisolventeOrdenINIM.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgCantidadDisolventeOrdenINIM.HeaderText = "Cantidad";
            this.dgCantidadDisolventeOrdenINIM.Name = "dgCantidadDisolventeOrdenINIM";
            this.dgCantidadDisolventeOrdenINIM.ReadOnly = true;
            this.dgCantidadDisolventeOrdenINIM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgCantidadDisolventeOrdenINIM.Width = 63;
            // 
            // HoraInicial
            // 
            this.HoraInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // Mezcla
            // 
            this.Mezcla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mezcla.DataPropertyName = "Mezcla";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mezcla.DefaultCellStyle = dataGridViewCellStyle6;
            this.Mezcla.HeaderText = "Mezcla";
            this.Mezcla.Name = "Mezcla";
            this.Mezcla.ReadOnly = true;
            this.Mezcla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mezcla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mezcla.Width = 50;
            // 
            // dgDiasTratamientoOrdenINIM
            // 
            this.dgDiasTratamientoOrdenINIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgDiasTratamientoOrdenINIM.DataPropertyName = "Dias Tto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDiasTratamientoOrdenINIM.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgDiasTratamientoOrdenINIM.HeaderText = "Dias Tto";
            this.dgDiasTratamientoOrdenINIM.Name = "dgDiasTratamientoOrdenINIM";
            this.dgDiasTratamientoOrdenINIM.ReadOnly = true;
            this.dgDiasTratamientoOrdenINIM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgDiasTratamientoOrdenINIM.Width = 70;
            // 
            // Suspender
            // 
            this.Suspender.DataPropertyName = "Suspender";
            this.Suspender.HeaderText = "Suspender";
            this.Suspender.Name = "Suspender";
            this.Suspender.ReadOnly = true;
            this.Suspender.Width = 74;
            // 
            // dgAceptaDisolventeOrdenINIM
            // 
            this.dgAceptaDisolventeOrdenINIM.DataPropertyName = "Acepta disolvente";
            this.dgAceptaDisolventeOrdenINIM.HeaderText = "Acepta disolvente";
            this.dgAceptaDisolventeOrdenINIM.Name = "dgAceptaDisolventeOrdenINIM";
            this.dgAceptaDisolventeOrdenINIM.ReadOnly = true;
            this.dgAceptaDisolventeOrdenINIM.Visible = false;
            this.dgAceptaDisolventeOrdenINIM.Width = 128;
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
            // InfusionImpregnacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.GroupBox63);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "InfusionImpregnacionUI";
            this.Text = "InfusionImpregnacionUI";
            this.Load += new System.EventHandler(this.InfusionImpregnacionUI_Load);
            this.GroupBox63.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenInfusionImpregnacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        internal System.Windows.Forms.GroupBox GroupBox63;
        public System.Windows.Forms.DataGridView dgvOrdenInfusionImpregnacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquivalencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnidadOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchora;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquivalenciaDisolvente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disolvente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCantidadDisolventeOrdenINIM;
        private System.Windows.Forms.DataGridViewComboBoxColumn HoraInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mezcla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDiasTratamientoOrdenINIM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Suspender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAceptaDisolventeOrdenINIM;
        private System.Windows.Forms.DataGridViewImageColumn agregar;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
    }
}