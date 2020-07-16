namespace Vista
{
    partial class PrincipalUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalUI));
            this.stsInformacionGeneral = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stsInformacionGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsInformacionGeneral
            // 
            this.stsInformacionGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.stsInformacionGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.stsInformacionGeneral.Location = new System.Drawing.Point(0, 431);
            this.stsInformacionGeneral.Name = "stsInformacionGeneral";
            this.stsInformacionGeneral.Size = new System.Drawing.Size(890, 22);
            this.stsInformacionGeneral.TabIndex = 2;
            this.stsInformacionGeneral.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";            
            // 
            // PrincipalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = Properties.Resources.principal_fondo;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.stsInformacionGeneral);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalUI";
            this.Text = "Galactus V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalUI_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.stsInformacionGeneral.ResumeLayout(false);
            this.stsInformacionGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip stsInformacionGeneral;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}



