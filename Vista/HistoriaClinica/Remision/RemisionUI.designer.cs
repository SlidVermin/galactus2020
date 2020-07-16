using Vista.General;

namespace Vista.HistoriaClinica.Remision
{
    partial class RemisionUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemisionUI));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtIdEvolucion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.tcOrdenMedica = new TabControlGalactus();
            this.tpAnexo = new System.Windows.Forms.TabPage();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tstMenu.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(208, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(137, 21);
            this.dtpFecha.TabIndex = 67;
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
            this.tstPropiedadesOrdenMedica.TabIndex = 66;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            this.tstPropiedadesOrdenMedica.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tstPropiedadesOrdenMedica_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Código:";
            // 
            // txtIdEvolucion
            // 
            this.txtIdEvolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEvolucion.Name = "txtIdEvolucion";
            this.txtIdEvolucion.ReadOnly = true;
            this.txtIdEvolucion.Size = new System.Drawing.Size(100, 25);
            this.txtIdEvolucion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "Fecha:";
            // 
            // tstMenu
            // 
            this.tstMenu.BackColor = System.Drawing.Color.White;
            this.tstMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtNuevo,
            this.tsBtModificar,
            this.tsBtGuardar,
            this.tsBtCancelar,
            this.tsBtBuscar,
            this.tsBtAnular});
            this.tstMenu.Location = new System.Drawing.Point(0, 332);
            this.tstMenu.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(1095, 25);
            this.tstMenu.TabIndex = 65;
            this.tstMenu.Text = "toolStrip1";
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpAnexo);
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(4, 28);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(1096, 305);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 64;
            // 
            // tpAnexo
            // 
            this.tpAnexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpAnexo.Location = new System.Drawing.Point(124, 4);
            this.tpAnexo.Name = "tpAnexo";
            this.tpAnexo.Size = new System.Drawing.Size(968, 297);
            this.tpAnexo.TabIndex = 3;
            this.tpAnexo.Text = "Anexo9";
            // 
            // RemisionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenu);
            this.Controls.Add(this.tcOrdenMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "RemisionUI";
            this.Text = "RemisionUI";
            this.Load += new System.EventHandler(this.RemisionUI_Load);
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            this.tcOrdenMedica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtIdEvolucion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip tstMenu;
        private System.Windows.Forms.TabPage tpAnexo;
        private TabControlGalactus tcOrdenMedica;
    }
}