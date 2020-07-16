namespace Vista.General
{
    partial class VentanaEntradaDatosUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEntradaDatosUI));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1.SuspendLayout();
            this.tstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.tstMenu);
            this.GroupBox1.Controls.Add(this.txtTexto);
            this.GroupBox1.Location = new System.Drawing.Point(6, 30);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(643, 288);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // tstMenu
            // 
            this.tstMenu.BackColor = System.Drawing.Color.White;
            this.tstMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtGuardar,
            this.tsBtCancelar});
            this.tstMenu.Location = new System.Drawing.Point(3, 260);
            this.tstMenu.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(1095, 25);
            this.tstMenu.TabIndex = 66;
            this.tstMenu.Text = "toolStrip1";
            // 
            // txtTexto
            // 
            this.txtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto.Location = new System.Drawing.Point(6, 19);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(631, 238);
            this.txtTexto.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(623, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 67;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            // VentanaEntradaDatosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 323);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(654, 323);
            this.MinimumSize = new System.Drawing.Size(654, 323);
            this.Name = "VentanaEntradaDatosUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaEntradaDatosUI";
            this.Load += new System.EventHandler(this.VentanaEntradaDatosUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VentanaEntradaDatosUI_KeyDown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ToolStrip tstMenu;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}