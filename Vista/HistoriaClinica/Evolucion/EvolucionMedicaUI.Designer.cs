using Vista.General;

namespace Vista.HistoriaClinica.Evolucion
{
    partial class EvolucionMedicaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvolucionMedicaUI));
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtIdEvolucion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.tstMenuEvolucion = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tcOrdenMedica = new TabControlGalactus();
            this.tpProblemas = new System.Windows.Forms.TabPage();
            this.tpExamenFisico = new System.Windows.Forms.TabPage();
            this.tpAnalisis = new System.Windows.Forms.TabPage();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tstMenuEvolucion.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel2.Text = "Fecha evolucion:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtIdEvolucion
            // 
            this.txtIdEvolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEvolucion.Name = "txtIdEvolucion";
            this.txtIdEvolucion.ReadOnly = true;
            this.txtIdEvolucion.Size = new System.Drawing.Size(100, 25);
            this.txtIdEvolucion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel1.Text = "Código evolucion:";
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.White;
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtIdEvolucion,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 62;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            this.tstPropiedadesOrdenMedica.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tstPropiedadesOrdenMedica_ItemClicked);
            // 
            // tstMenuEvolucion
            // 
            this.tstMenuEvolucion.BackColor = System.Drawing.Color.White;
            this.tstMenuEvolucion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuEvolucion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtNuevo,
            this.tsBtModificar,
            this.tsBtGuardar,
            this.tsBtCancelar,
            this.tsBtBuscar,
            this.tsBtAnular});
            this.tstMenuEvolucion.Location = new System.Drawing.Point(0, 332);
            this.tstMenuEvolucion.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.Name = "tstMenuEvolucion";
            this.tstMenuEvolucion.Size = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.TabIndex = 61;
            this.tstMenuEvolucion.Text = "toolStrip1";
            // 
            // tsBtNuevo
            // 
            this.tsBtNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtNuevo.Image")));
            this.tsBtNuevo.ImageTransparentColor = System.Drawing.Color.White;
            this.tsBtNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtNuevo.Name = "tsBtNuevo";
            this.tsBtNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsBtNuevo.Text = "Nuevo";
            this.tsBtNuevo.Click += new System.EventHandler(this.tsBtNuevo_Click);
            // 
            // tsBtModificar
            // 
            this.tsBtModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtModificar.Image")));
            this.tsBtModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtModificar.Name = "tsBtModificar";
            this.tsBtModificar.Size = new System.Drawing.Size(78, 22);
            this.tsBtModificar.Text = "Modificar";
            this.tsBtModificar.Click += new System.EventHandler(this.tsBtModificar_Click);
            // 
            // tsBtGuardar
            // 
            this.tsBtGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtGuardar.Image")));
            this.tsBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtGuardar.Name = "tsBtGuardar";
            this.tsBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsBtGuardar.Text = "Guardar";
            this.tsBtGuardar.Click += new System.EventHandler(this.tsBtGuardar_Click);
            // 
            // tsBtCancelar
            // 
            this.tsBtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtCancelar.Image")));
            this.tsBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtCancelar.Name = "tsBtCancelar";
            this.tsBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsBtCancelar.Text = "Cancelar";
            this.tsBtCancelar.Click += new System.EventHandler(this.tsBtCancelar_Click);
            // 
            // tsBtBuscar
            // 
            this.tsBtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtBuscar.Image")));
            this.tsBtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtBuscar.Name = "tsBtBuscar";
            this.tsBtBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsBtBuscar.Text = "Buscar";
            this.tsBtBuscar.Click += new System.EventHandler(this.tsBtBuscar_Click);
            // 
            // tsBtAnular
            // 
            this.tsBtAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsBtAnular.Image")));
            this.tsBtAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtAnular.Name = "tsBtAnular";
            this.tsBtAnular.Size = new System.Drawing.Size(62, 22);
            this.tsBtAnular.Text = "Anular";
            this.tsBtAnular.Click += new System.EventHandler(this.tsBtAnular_Click);
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpProblemas);
            this.tcOrdenMedica.Controls.Add(this.tpExamenFisico);
            this.tcOrdenMedica.Controls.Add(this.tpAnalisis);
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(3, 28);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(1096, 305);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 60;
            // 
            // tpProblemas
            // 
            this.tpProblemas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProblemas.Location = new System.Drawing.Point(124, 4);
            this.tpProblemas.Name = "tpProblemas";
            this.tpProblemas.Padding = new System.Windows.Forms.Padding(3);
            this.tpProblemas.Size = new System.Drawing.Size(968, 297);
            this.tpProblemas.TabIndex = 0;
            this.tpProblemas.Text = "Problemas";
            // 
            // tpExamenFisico
            // 
            this.tpExamenFisico.Location = new System.Drawing.Point(124, 4);
            this.tpExamenFisico.Name = "tpExamenFisico";
            this.tpExamenFisico.Padding = new System.Windows.Forms.Padding(3);
            this.tpExamenFisico.Size = new System.Drawing.Size(968, 297);
            this.tpExamenFisico.TabIndex = 1;
            this.tpExamenFisico.Text = "Examen Fisico";
            this.tpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // tpAnalisis
            // 
            this.tpAnalisis.Location = new System.Drawing.Point(124, 4);
            this.tpAnalisis.Name = "tpAnalisis";
            this.tpAnalisis.Size = new System.Drawing.Size(968, 297);
            this.tpAnalisis.TabIndex = 3;
            this.tpAnalisis.Text = "Analisis";
            this.tpAnalisis.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(321, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(137, 21);
            this.dtpFecha.TabIndex = 63;
            // 
            // EvolucionMedicaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenuEvolucion);
            this.Controls.Add(this.tcOrdenMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "EvolucionMedicaUI";
            this.Text = "EvolucionMedicaUI";
            this.Load += new System.EventHandler(this.EvolucionMedicaUI_Load);
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tstMenuEvolucion.ResumeLayout(false);
            this.tstMenuEvolucion.PerformLayout();
            this.tcOrdenMedica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpProblemas;
        private System.Windows.Forms.TabPage tpExamenFisico;
        private System.Windows.Forms.TabPage tpAnalisis;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtIdEvolucion;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStrip tstMenuEvolucion;
        private TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}