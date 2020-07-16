namespace Vista.HistoriaClinica.Evolucion
{
    partial class InterpretacionUI
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
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvImpresionN = new System.Windows.Forms.DataGridView();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresionN)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvImpresionN);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F);
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(5, 4);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(958, 273);
            this.GroupBox17.TabIndex = 10094;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Interpretación";
            // 
            // dgvImpresionN
            // 
            this.dgvImpresionN.AllowUserToAddRows = false;
            this.dgvImpresionN.AllowUserToDeleteRows = false;
            this.dgvImpresionN.AllowUserToResizeColumns = false;
            this.dgvImpresionN.AllowUserToResizeRows = false;
            this.dgvImpresionN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImpresionN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImpresionN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvImpresionN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpresionN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpresionN.Location = new System.Drawing.Point(3, 17);
            this.dgvImpresionN.MultiSelect = false;
            this.dgvImpresionN.Name = "dgvImpresionN";
            this.dgvImpresionN.ReadOnly = true;
            this.dgvImpresionN.RowHeadersVisible = false;
            this.dgvImpresionN.ShowCellErrors = false;
            this.dgvImpresionN.ShowCellToolTips = false;
            this.dgvImpresionN.ShowEditingIcon = false;
            this.dgvImpresionN.ShowRowErrors = false;
            this.dgvImpresionN.Size = new System.Drawing.Size(952, 253);
            this.dgvImpresionN.TabIndex = 2;
            // 
            // InterpretacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 284);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterpretacionUI";
            this.Text = "InterpretacionUI";
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresionN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvImpresionN;
    }
}