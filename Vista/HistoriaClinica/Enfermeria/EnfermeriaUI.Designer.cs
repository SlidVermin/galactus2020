using Vista.General;

namespace Vista.HistoriaClinica.Enfermeria
{
    partial class EnfermeriaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnfermeriaUI));
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCodigo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.mtxtFechaEvolucion = new System.Windows.Forms.MaskedTextBox();
            this.tpGlucometrias = new System.Windows.Forms.TabPage();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tcEnfermeria = new TabControlGalactus();
            this.tpInsumos = new System.Windows.Forms.TabPage();
            this.tpNotas = new System.Windows.Forms.TabPage();
            this.tpParaclinicos = new System.Windows.Forms.TabPage();
            this.tpProcedimientos = new System.Windows.Forms.TabPage();
            this.tpGlucometria = new System.Windows.Forms.TabPage();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tstMenu.SuspendLayout();
            this.tcEnfermeria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtCodigo,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 66;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tstMenu.Location = new System.Drawing.Point(0, 320);
            this.tstMenu.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(1095, 25);
            this.tstMenu.TabIndex = 65;
            this.tstMenu.Text = "toolStrip1";
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
            // 
            // mtxtFechaEvolucion
            // 
            this.mtxtFechaEvolucion.Location = new System.Drawing.Point(308, 2);
            this.mtxtFechaEvolucion.Mask = "00/00/0000 00:00";
            this.mtxtFechaEvolucion.Name = "mtxtFechaEvolucion";
            this.mtxtFechaEvolucion.ReadOnly = true;
            this.mtxtFechaEvolucion.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaEvolucion.TabIndex = 67;
            this.mtxtFechaEvolucion.ValidatingType = typeof(System.DateTime);
            // 
            // tpGlucometrias
            // 
            this.tpGlucometrias.Location = new System.Drawing.Point(124, 4);
            this.tpGlucometrias.Name = "tpGlucometrias";
            this.tpGlucometrias.Size = new System.Drawing.Size(968, 297);
            this.tpGlucometrias.TabIndex = 4;
            this.tpGlucometrias.Text = "Glucometrias";
            this.tpGlucometrias.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(215, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(137, 21);
            this.dtpFecha.TabIndex = 68;
            // 
            // tcEnfermeria
            // 
            this.tcEnfermeria.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcEnfermeria.Controls.Add(this.tpInsumos);
            this.tcEnfermeria.Controls.Add(this.tpNotas);
            this.tcEnfermeria.Controls.Add(this.tpParaclinicos);
            this.tcEnfermeria.Controls.Add(this.tpProcedimientos);
            this.tcEnfermeria.Controls.Add(this.tpGlucometria);
            this.tcEnfermeria.ItemSize = new System.Drawing.Size(30, 120);
            this.tcEnfermeria.Location = new System.Drawing.Point(4, 28);
            this.tcEnfermeria.Multiline = true;
            this.tcEnfermeria.Name = "tcEnfermeria";
            this.tcEnfermeria.SelectedIndex = 0;
            this.tcEnfermeria.Size = new System.Drawing.Size(1082, 289);
            this.tcEnfermeria.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcEnfermeria.TabIndex = 64;
            this.tcEnfermeria.SelectedIndexChanged += new System.EventHandler(this.tcEnfermeria_SelectedIndexChanged);
            this.tcEnfermeria.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcEnfermeria_Selecting);
            // 
            // tpInsumos
            // 
            this.tpInsumos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpInsumos.Location = new System.Drawing.Point(124, 4);
            this.tpInsumos.Name = "tpInsumos";
            this.tpInsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tpInsumos.Size = new System.Drawing.Size(954, 281);
            this.tpInsumos.TabIndex = 0;
            this.tpInsumos.Text = "Insumos";
            // 
            // tpNotas
            // 
            this.tpNotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpNotas.Location = new System.Drawing.Point(124, 4);
            this.tpNotas.Name = "tpNotas";
            this.tpNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotas.Size = new System.Drawing.Size(954, 281);
            this.tpNotas.TabIndex = 1;
            this.tpNotas.Text = "Notas";
            // 
            // tpParaclinicos
            // 
            this.tpParaclinicos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpParaclinicos.Location = new System.Drawing.Point(124, 4);
            this.tpParaclinicos.Name = "tpParaclinicos";
            this.tpParaclinicos.Size = new System.Drawing.Size(954, 281);
            this.tpParaclinicos.TabIndex = 2;
            this.tpParaclinicos.Text = "Paraclinicos";
            // 
            // tpProcedimientos
            // 
            this.tpProcedimientos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpProcedimientos.Location = new System.Drawing.Point(124, 4);
            this.tpProcedimientos.Name = "tpProcedimientos";
            this.tpProcedimientos.Size = new System.Drawing.Size(954, 281);
            this.tpProcedimientos.TabIndex = 3;
            this.tpProcedimientos.Text = "Procedimientos";
            // 
            // tpGlucometria
            // 
            this.tpGlucometria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpGlucometria.Location = new System.Drawing.Point(124, 4);
            this.tpGlucometria.Name = "tpGlucometria";
            this.tpGlucometria.Size = new System.Drawing.Size(954, 281);
            this.tpGlucometria.TabIndex = 4;
            this.tpGlucometria.Text = "Glucometrias";
            // 
            // EnfermeriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1090, 345);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenu);
            this.Controls.Add(this.mtxtFechaEvolucion);
            this.Controls.Add(this.tcEnfermeria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1090, 345);
            this.MinimumSize = new System.Drawing.Size(1090, 345);
            this.Name = "EnfermeriaUI";
            this.Text = "EnfermeriaUI";
            this.Load += new System.EventHandler(this.EnfermeriaUI_Load);
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            this.tcEnfermeria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpInsumos;
        private System.Windows.Forms.TabPage tpNotas;
        private System.Windows.Forms.TabPage tpProcedimientos;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtCodigo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip tstMenu;
        private System.Windows.Forms.MaskedTextBox mtxtFechaEvolucion;
        private System.Windows.Forms.TabPage tpParaclinicos;
        private TabControlGalactus tcEnfermeria;
        private System.Windows.Forms.TabPage tpGlucometrias;
        private System.Windows.Forms.TabPage tpGlucometria;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}