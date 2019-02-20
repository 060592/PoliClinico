namespace AppPostaMedica
{
    partial class fmReportePacientes
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
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.CachedPageNumberPerDoc = 10;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporte.Location = new System.Drawing.Point(0, 75);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.Size = new System.Drawing.Size(701, 451);
            this.crvReporte.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 78);
            this.panel2.TabIndex = 6;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(306, 33);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 0;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buReporte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 75);
            this.panel1.TabIndex = 5;
            // 
            // buReporte
            // 
            this.buReporte.Location = new System.Drawing.Point(537, 26);
            this.buReporte.Name = "buReporte";
            this.buReporte.Size = new System.Drawing.Size(75, 23);
            this.buReporte.TabIndex = 1;
            this.buReporte.Text = "Ver Reporte";
            this.buReporte.UseVisualStyleBackColor = true;
            this.buReporte.Click += new System.EventHandler(this.buReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE PACIENTES";
            // 
            // fmReportePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 604);
            this.Controls.Add(this.crvReporte);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmReportePacientes";
            this.Text = "fmReportePacientes";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buReporte;
        private System.Windows.Forms.Label label1;
    }
}