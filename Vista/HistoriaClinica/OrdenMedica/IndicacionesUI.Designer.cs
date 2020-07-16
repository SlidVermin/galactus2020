namespace Vista.HistoriaClinica.OrdenMedica
{
    partial class IndicacionesUI
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
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndicaciones.Location = new System.Drawing.Point(6, 21);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIndicaciones.Size = new System.Drawing.Size(950, 249);
            this.txtIndicaciones.TabIndex = 0;
            this.txtIndicaciones.TextChanged += new System.EventHandler(this.txtIndicaciones_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 287);
            this.panel1.TabIndex = 2;
            // 
            // GroupBox17
            // 
            this.GroupBox17.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox17.Controls.Add(this.txtIndicaciones);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 276);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Indicaciones";
            // 
            // IndicacionesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "IndicacionesUI";
            this.Text = "Indicaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndiceacionesUI_FormClosing);
            this.Load += new System.EventHandler(this.IndiceacionesUI_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        public System.Windows.Forms.TextBox txtIndicaciones;
    }
}