using Vista.General;

namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class IngresoClinicoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoClinicoUI));
            this.tsIngreso = new System.Windows.Forms.ToolStrip();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tstImprimir = new System.Windows.Forms.ToolStripButton();
            this.tcIngresoClinico = new TabControlGalactus();
            this.tpValoracion = new System.Windows.Forms.TabPage();
            this.tpAntecedentes = new System.Windows.Forms.TabPage();
            this.tpAntecedentesMaterno = new System.Windows.Forms.TabPage();
            this.tpAntecedentesNacimiento = new System.Windows.Forms.TabPage();
            this.tpRecienNacido = new System.Windows.Forms.TabPage();
            this.tpExamenFisico = new System.Windows.Forms.TabPage();
            this.tpAnalisis = new System.Windows.Forms.TabPage();
            this.tsIngreso.SuspendLayout();
            this.tcIngresoClinico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsIngreso
            // 
            this.tsIngreso.BackColor = System.Drawing.Color.White;
            this.tsIngreso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsIngreso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModificar,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tstImprimir});
            this.tsIngreso.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsIngreso.Location = new System.Drawing.Point(2, 332);
            this.tsIngreso.MaximumSize = new System.Drawing.Size(1097, 25);
            this.tsIngreso.MinimumSize = new System.Drawing.Size(1097, 25);
            this.tsIngreso.Name = "tsIngreso";
            this.tsIngreso.Size = new System.Drawing.Size(1097, 25);
            this.tsIngreso.TabIndex = 53;
            this.tsIngreso.Text = "toolStrip2";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tstImprimir
            // 
            this.tstImprimir.Image = Vista.Properties.Resources.print__2_;
            this.tstImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstImprimir.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstImprimir.Name = "tstImprimir";
            this.tstImprimir.Size = new System.Drawing.Size(73, 22);
            this.tstImprimir.Text = "Imprimir";
            this.tstImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tcIngresoClinico
            // 
            this.tcIngresoClinico.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcIngresoClinico.Controls.Add(this.tpValoracion);
            this.tcIngresoClinico.Controls.Add(this.tpAntecedentes);
            this.tcIngresoClinico.Controls.Add(this.tpAntecedentesMaterno);
            this.tcIngresoClinico.Controls.Add(this.tpAntecedentesNacimiento);
            this.tcIngresoClinico.Controls.Add(this.tpRecienNacido);
            this.tcIngresoClinico.Controls.Add(this.tpExamenFisico);
            this.tcIngresoClinico.Controls.Add(this.tpAnalisis);
            this.tcIngresoClinico.ItemSize = new System.Drawing.Size(30, 120);
            this.tcIngresoClinico.Location = new System.Drawing.Point(2, 3);
            this.tcIngresoClinico.Multiline = true;
            this.tcIngresoClinico.Name = "tcIngresoClinico";
            this.tcIngresoClinico.SelectedIndex = 0;
            this.tcIngresoClinico.Size = new System.Drawing.Size(1100, 326);
            this.tcIngresoClinico.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcIngresoClinico.TabIndex = 4;
            // 
            // tpValoracion
            // 
            this.tpValoracion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpValoracion.Location = new System.Drawing.Point(124, 4);
            this.tpValoracion.Name = "tpValoracion";
            this.tpValoracion.Padding = new System.Windows.Forms.Padding(3);
            this.tpValoracion.Size = new System.Drawing.Size(972, 318);
            this.tpValoracion.TabIndex = 0;
            this.tpValoracion.Text = "Valoración";
            // 
            // tpAntecedentes
            // 
            this.tpAntecedentes.Location = new System.Drawing.Point(124, 4);
            this.tpAntecedentes.Name = "tpAntecedentes";
            this.tpAntecedentes.Padding = new System.Windows.Forms.Padding(3);
            this.tpAntecedentes.Size = new System.Drawing.Size(972, 318);
            this.tpAntecedentes.TabIndex = 1;
            this.tpAntecedentes.Text = "Antecedentes";
            this.tpAntecedentes.UseVisualStyleBackColor = true;
            // 
            // tpAntecedentesMaterno
            // 
            this.tpAntecedentesMaterno.Location = new System.Drawing.Point(124, 4);
            this.tpAntecedentesMaterno.Name = "tpAntecedentesMaterno";
            this.tpAntecedentesMaterno.Padding = new System.Windows.Forms.Padding(3);
            this.tpAntecedentesMaterno.Size = new System.Drawing.Size(972, 318);
            this.tpAntecedentesMaterno.TabIndex = 4;
            this.tpAntecedentesMaterno.Text = "Ant. Maternos";
            this.tpAntecedentesMaterno.UseVisualStyleBackColor = true;
            // 
            // tpAntecedentesNacimiento
            // 
            this.tpAntecedentesNacimiento.Location = new System.Drawing.Point(124, 4);
            this.tpAntecedentesNacimiento.Name = "tpAntecedentesNacimiento";
            this.tpAntecedentesNacimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpAntecedentesNacimiento.Size = new System.Drawing.Size(972, 318);
            this.tpAntecedentesNacimiento.TabIndex = 5;
            this.tpAntecedentesNacimiento.Text = "Ant. del nacimiento";
            this.tpAntecedentesNacimiento.UseVisualStyleBackColor = true;
            // 
            // tpRecienNacido
            // 
            this.tpRecienNacido.Location = new System.Drawing.Point(124, 4);
            this.tpRecienNacido.Name = "tpRecienNacido";
            this.tpRecienNacido.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecienNacido.Size = new System.Drawing.Size(972, 318);
            this.tpRecienNacido.TabIndex = 6;
            this.tpRecienNacido.Text = "Ant. del recien nacido";
            this.tpRecienNacido.UseVisualStyleBackColor = true;
            // 
            // tpExamenFisico
            // 
            this.tpExamenFisico.Location = new System.Drawing.Point(124, 4);
            this.tpExamenFisico.Name = "tpExamenFisico";
            this.tpExamenFisico.Size = new System.Drawing.Size(972, 318);
            this.tpExamenFisico.TabIndex = 2;
            this.tpExamenFisico.Text = "Examen físico";
            this.tpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // tpAnalisis
            // 
            this.tpAnalisis.Location = new System.Drawing.Point(124, 4);
            this.tpAnalisis.Name = "tpAnalisis";
            this.tpAnalisis.Size = new System.Drawing.Size(972, 318);
            this.tpAnalisis.TabIndex = 3;
            this.tpAnalisis.Text = "Análisis";
            this.tpAnalisis.UseVisualStyleBackColor = true;
            // 
            // IngresoClinicoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.tsIngreso);
            this.Controls.Add(this.tcIngresoClinico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "IngresoClinicoUI";
            this.RightToLeftLayout = true;
            this.Text = "IngresoClinico";
            this.Load += new System.EventHandler(this.IngresoClinicoUI_Load);
            this.Shown += new System.EventHandler(this.IngresoClinicoUI_Shown);
            this.tsIngreso.ResumeLayout(false);
            this.tsIngreso.PerformLayout();
            this.tcIngresoClinico.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpAnalisis;
        private System.Windows.Forms.TabPage tpExamenFisico;
        private System.Windows.Forms.TabPage tpAntecedentes;
        private System.Windows.Forms.TabPage tpValoracion;
        private TabControlGalactus tcIngresoClinico;
        private System.Windows.Forms.ToolStrip tsIngreso;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.TabPage tpAntecedentesMaterno;
        private System.Windows.Forms.TabPage tpAntecedentesNacimiento;
        private System.Windows.Forms.TabPage tpRecienNacido;
        private System.Windows.Forms.ToolStripButton tstImprimir;
    }
}