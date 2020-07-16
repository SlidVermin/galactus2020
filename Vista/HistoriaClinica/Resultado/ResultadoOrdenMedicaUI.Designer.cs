using Vista.General;

namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class ResultadoOrdenMedicaUI
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
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBCodigoOrden = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tcOrdenMedica = new TabControlGalactus();
            this.tpLaboratorio = new System.Windows.Forms.TabPage();
            this.tpImagenologia = new System.Windows.Forms.TabPage();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.White;
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtBCodigoOrden,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1040, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 58;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Código Orden:";
            // 
            // txtBCodigoOrden
            // 
            this.txtBCodigoOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBCodigoOrden.Name = "txtBCodigoOrden";
            this.txtBCodigoOrden.Size = new System.Drawing.Size(100, 25);
            this.txtBCodigoOrden.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Fecha Orden:";
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpLaboratorio);
            this.tcOrdenMedica.Controls.Add(this.tpImagenologia);
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(2, 28);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(1096, 317);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 56;
            // 
            // tpLaboratorio
            // 
            this.tpLaboratorio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpLaboratorio.Location = new System.Drawing.Point(124, 4);
            this.tpLaboratorio.Name = "tpLaboratorio";
            this.tpLaboratorio.Padding = new System.Windows.Forms.Padding(3);
            this.tpLaboratorio.Size = new System.Drawing.Size(968, 309);
            this.tpLaboratorio.TabIndex = 0;
            this.tpLaboratorio.Text = "Laboratorio";
            // 
            // tpImagenologia
            // 
            this.tpImagenologia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpImagenologia.Location = new System.Drawing.Point(124, 4);
            this.tpImagenologia.Name = "tpImagenologia";
            this.tpImagenologia.Size = new System.Drawing.Size(968, 309);
            this.tpImagenologia.TabIndex = 1;
            this.tpImagenologia.Text = "Ayudas Diagnosticas";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(286, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(137, 21);
            this.dtpFecha.TabIndex = 59;
            // 
            // ResultadoOrdenMedicaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tcOrdenMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "ResultadoOrdenMedicaUI";
            this.Text = "ResultadoOrdenMedicaUI";
            this.Load += new System.EventHandler(this.ResultadoOrdenMedicaUI_Load);
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tcOrdenMedica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.TabPage tpLaboratorio;
        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.ToolStripTextBox txtBCodigoOrden;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TabPage tpImagenologia;
    }
}