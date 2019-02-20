namespace AppPostaMedica
{
    partial class fmPagoAtencion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNroRecibo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.buConsulta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPaciente = new System.Windows.Forms.TextBox();
            this.buConsultaP = new System.Windows.Forms.Button();
            this.tbIDpaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.buConsultaE = new System.Windows.Forms.Button();
            this.tbIDespecialidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCESO PAGO DE ATENCIÓN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Controls.Add(this.buGrabar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 94);
            this.panel2.TabIndex = 1;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(559, 36);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // buGrabar
            // 
            this.buGrabar.Location = new System.Drawing.Point(117, 36);
            this.buGrabar.Name = "buGrabar";
            this.buGrabar.Size = new System.Drawing.Size(75, 23);
            this.buGrabar.TabIndex = 0;
            this.buGrabar.Text = "Grabar";
            this.buGrabar.UseVisualStyleBackColor = true;
            this.buGrabar.Click += new System.EventHandler(this.buGrabar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro. Recibo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe :";
            // 
            // tbNroRecibo
            // 
            this.tbNroRecibo.Location = new System.Drawing.Point(137, 104);
            this.tbNroRecibo.Name = "tbNroRecibo";
            this.tbNroRecibo.Size = new System.Drawing.Size(100, 20);
            this.tbNroRecibo.TabIndex = 5;
            this.tbNroRecibo.Leave += new System.EventHandler(this.tbNroRecibo_Leave);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(122, 141);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(117, 193);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(83, 20);
            this.tbImporte.TabIndex = 7;
            // 
            // buConsulta
            // 
            this.buConsulta.Location = new System.Drawing.Point(267, 102);
            this.buConsulta.Name = "buConsulta";
            this.buConsulta.Size = new System.Drawing.Size(75, 23);
            this.buConsulta.TabIndex = 8;
            this.buConsulta.Text = "Consultar";
            this.buConsulta.UseVisualStyleBackColor = true;
            this.buConsulta.Click += new System.EventHandler(this.buConsulta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPaciente);
            this.groupBox1.Controls.Add(this.buConsultaP);
            this.groupBox1.Controls.Add(this.tbIDpaciente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 137);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // tbPaciente
            // 
            this.tbPaciente.Enabled = false;
            this.tbPaciente.Location = new System.Drawing.Point(217, 91);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.Size = new System.Drawing.Size(391, 20);
            this.tbPaciente.TabIndex = 3;
            // 
            // buConsultaP
            // 
            this.buConsultaP.Location = new System.Drawing.Point(273, 29);
            this.buConsultaP.Name = "buConsultaP";
            this.buConsultaP.Size = new System.Drawing.Size(141, 23);
            this.buConsultaP.TabIndex = 2;
            this.buConsultaP.Text = "Consultar Pacientes";
            this.buConsultaP.UseVisualStyleBackColor = true;
            this.buConsultaP.Click += new System.EventHandler(this.buConsultaP_Click);
            // 
            // tbIDpaciente
            // 
            this.tbIDpaciente.Location = new System.Drawing.Point(105, 31);
            this.tbIDpaciente.Name = "tbIDpaciente";
            this.tbIDpaciente.Size = new System.Drawing.Size(100, 20);
            this.tbIDpaciente.TabIndex = 1;
            this.tbIDpaciente.Leave += new System.EventHandler(this.tbIDpaciente_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Paciente :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEspecialidad);
            this.groupBox2.Controls.Add(this.buConsultaE);
            this.groupBox2.Controls.Add(this.tbIDespecialidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 137);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especialidad";
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Enabled = false;
            this.tbEspecialidad.Location = new System.Drawing.Point(217, 91);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(391, 20);
            this.tbEspecialidad.TabIndex = 3;
            // 
            // buConsultaE
            // 
            this.buConsultaE.Location = new System.Drawing.Point(273, 29);
            this.buConsultaE.Name = "buConsultaE";
            this.buConsultaE.Size = new System.Drawing.Size(141, 23);
            this.buConsultaE.TabIndex = 2;
            this.buConsultaE.Text = "Consultar Especialidad";
            this.buConsultaE.UseVisualStyleBackColor = true;
            this.buConsultaE.Click += new System.EventHandler(this.buConsultaE_Click);
            // 
            // tbIDespecialidad
            // 
            this.tbIDespecialidad.Location = new System.Drawing.Point(115, 31);
            this.tbIDespecialidad.Name = "tbIDespecialidad";
            this.tbIDespecialidad.Size = new System.Drawing.Size(100, 20);
            this.tbIDespecialidad.TabIndex = 1;
            this.tbIDespecialidad.Leave += new System.EventHandler(this.tbIDespecialidad_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Especialidad :";
            // 
            // fmPagoAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buConsulta);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tbNroRecibo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPagoAtencion";
            this.Text = "fmPagoAtencion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNroRecibo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Button buConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPaciente;
        private System.Windows.Forms.Button buConsultaP;
        private System.Windows.Forms.TextBox tbIDpaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.Button buConsultaE;
        private System.Windows.Forms.TextBox tbIDespecialidad;
        private System.Windows.Forms.Label label6;
    }
}