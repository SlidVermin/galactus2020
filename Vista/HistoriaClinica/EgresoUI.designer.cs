using Vista.General;

namespace Vista.HistoriaClinica
{
    partial class EgresoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgresoUI));
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstMenuEvolucion = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tpSalida = new System.Windows.Forms.TabPage();
            this.tpResumen = new System.Windows.Forms.TabPage();
            this.tcOrdenMedica = new TabControlGalactus();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.btBuscarDestino = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscarInstitucion = new System.Windows.Forms.Button();
            this.cmbEstadoSalida = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResumen = new System.Windows.Forms.RichTextBox();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tstMenuEvolucion.SuspendLayout();
            this.tpSalida.SuspendLayout();
            this.tpResumen.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.White;
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 65;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel2.Text = "Fecha de salida:";
            // 
            // tstMenuEvolucion
            // 
            this.tstMenuEvolucion.BackColor = System.Drawing.Color.White;
            this.tstMenuEvolucion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuEvolucion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtNuevo,
            this.tsBtModificar,
            this.tsBtGuardar,
            this.tsBtBuscar,
            this.tsBtAnular,
            this.tsBtCancelar});
            this.tstMenuEvolucion.Location = new System.Drawing.Point(0, 332);
            this.tstMenuEvolucion.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.Name = "tstMenuEvolucion";
            this.tstMenuEvolucion.Size = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.TabIndex = 64;
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
            // 
            // tpSalida
            // 
            this.tpSalida.Controls.Add(this.cmbEstadoSalida);
            this.tpSalida.Controls.Add(this.label12);
            this.tpSalida.Controls.Add(this.btBuscarInstitucion);
            this.tpSalida.Controls.Add(this.txtInstitucion);
            this.tpSalida.Controls.Add(this.label1);
            this.tpSalida.Controls.Add(this.btBuscarDestino);
            this.tpSalida.Controls.Add(this.txtDestino);
            this.tpSalida.Controls.Add(this.label5);
            this.tpSalida.Controls.Add(this.groupBox1);
            this.tpSalida.Location = new System.Drawing.Point(124, 4);
            this.tpSalida.Name = "tpSalida";
            this.tpSalida.Padding = new System.Windows.Forms.Padding(3);
            this.tpSalida.Size = new System.Drawing.Size(968, 297);
            this.tpSalida.TabIndex = 1;
            this.tpSalida.Text = "Salida";
            this.tpSalida.UseVisualStyleBackColor = true;
            // 
            // tpResumen
            // 
            this.tpResumen.BackColor = System.Drawing.Color.Silver;
            this.tpResumen.Controls.Add(this.txtResumen);
            this.tpResumen.Location = new System.Drawing.Point(124, 4);
            this.tpResumen.Name = "tpResumen";
            this.tpResumen.Padding = new System.Windows.Forms.Padding(3);
            this.tpResumen.Size = new System.Drawing.Size(968, 297);
            this.tpResumen.TabIndex = 0;
            this.tpResumen.Text = "Resumen";
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpResumen);
            this.tcOrdenMedica.Controls.Add(this.tpSalida);
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(3, 28);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(1096, 305);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 188);
            this.groupBox1.TabIndex = 10096;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(3, 21);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(949, 164);
            this.txtObservacion.TabIndex = 0;
            this.txtObservacion.Text = "";
            // 
            // btBuscarDestino
            // 
            this.btBuscarDestino.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarDestino.Image = Properties.Resources.btn_lupa;
            this.btBuscarDestino.Location = new System.Drawing.Point(625, 46);
            this.btBuscarDestino.Name = "btBuscarDestino";
            this.btBuscarDestino.Size = new System.Drawing.Size(26, 24);
            this.btBuscarDestino.TabIndex = 10099;
            this.btBuscarDestino.UseVisualStyleBackColor = true;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(100, 48);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(519, 21);
            this.txtDestino.TabIndex = 10098;
            this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10097;
            this.label5.Text = "Destino:";
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucion.Location = new System.Drawing.Point(100, 75);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(519, 21);
            this.txtInstitucion.TabIndex = 10101;
            this.txtInstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 10100;
            this.label1.Text = "Institución:";
            // 
            // btBuscarInstitucion
            // 
            this.btBuscarInstitucion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarInstitucion.Image = Properties.Resources.btn_lupa;
            this.btBuscarInstitucion.Location = new System.Drawing.Point(625, 73);
            this.btBuscarInstitucion.Name = "btBuscarInstitucion";
            this.btBuscarInstitucion.Size = new System.Drawing.Size(26, 24);
            this.btBuscarInstitucion.TabIndex = 10102;
            this.btBuscarInstitucion.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoSalida
            // 
            this.cmbEstadoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoSalida.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbEstadoSalida.FormattingEnabled = true;
            this.cmbEstadoSalida.Location = new System.Drawing.Point(100, 18);
            this.cmbEstadoSalida.Name = "cmbEstadoSalida";
            this.cmbEstadoSalida.Size = new System.Drawing.Size(229, 23);
            this.cmbEstadoSalida.TabIndex = 10104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 10103;
            this.label12.Text = "Estado:";
            // 
            // txtResumen
            // 
            this.txtResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResumen.Location = new System.Drawing.Point(3, 3);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtResumen.Size = new System.Drawing.Size(962, 291);
            this.txtResumen.TabIndex = 1;
            this.txtResumen.Text = "";
            // 
            // EgresoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenuEvolucion);
            this.Controls.Add(this.tcOrdenMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "EgresoUI";
            this.Text = "EgresoUI";
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tstMenuEvolucion.ResumeLayout(false);
            this.tstMenuEvolucion.PerformLayout();
            this.tpSalida.ResumeLayout(false);
            this.tpSalida.PerformLayout();
            this.tpResumen.ResumeLayout(false);
            this.tcOrdenMedica.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip tstMenuEvolucion;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.TabPage tpSalida;
        private System.Windows.Forms.TabPage tpResumen;
        private TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Button btBuscarInstitucion;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscarDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstadoSalida;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.RichTextBox txtResumen;
    }
}