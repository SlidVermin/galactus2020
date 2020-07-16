namespace Vista.HistoriaClinica.IngresoMedico
{
    partial class AnalisisUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnalisis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPronostico = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnalisis);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 146);
            this.groupBox1.TabIndex = 10064;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Análisis";
            // 
            // txtAnalisis
            // 
            this.txtAnalisis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAnalisis.Location = new System.Drawing.Point(5, 15);
            this.txtAnalisis.Multiline = true;
            this.txtAnalisis.Name = "txtAnalisis";
            this.txtAnalisis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalisis.Size = new System.Drawing.Size(940, 125);
            this.txtAnalisis.TabIndex = 10063;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPronostico);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 141);
            this.groupBox2.TabIndex = 10065;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pronóstico";
            // 
            // txtPronostico
            // 
            this.txtPronostico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPronostico.Location = new System.Drawing.Point(5, 15);
            this.txtPronostico.Multiline = true;
            this.txtPronostico.Name = "txtPronostico";
            this.txtPronostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPronostico.Size = new System.Drawing.Size(940, 120);
            this.txtPronostico.TabIndex = 10064;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPlan);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(951, 121);
            this.groupBox3.TabIndex = 10066;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plan";
            // 
            // txtPlan
            // 
            this.txtPlan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(5, 15);
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlan.Size = new System.Drawing.Size(940, 100);
            this.txtPlan.TabIndex = 10064;
            // 
            // AnalisisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(969, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalisisUI";
            this.Text = "PronosticoUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtAnalisis;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtPronostico;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtPlan;
    }
}