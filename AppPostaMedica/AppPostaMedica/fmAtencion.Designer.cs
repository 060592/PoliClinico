namespace AppPostaMedica
{
    partial class fmAtencion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.tbIDespecialidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPaciente = new System.Windows.Forms.TextBox();
            this.tbIDpaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buConsulta = new System.Windows.Forms.Button();
            this.tbIDmedico = new System.Windows.Forms.TextBox();
            this.tbNroRecibo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDiagnostico = new System.Windows.Forms.TextBox();
            this.tbTratamiento = new System.Windows.Forms.TextBox();
            this.buConsultaMedico = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEspecialidad);
            this.groupBox2.Controls.Add(this.tbIDespecialidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 137);
            this.groupBox2.TabIndex = 21;
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
            // tbIDespecialidad
            // 
            this.tbIDespecialidad.Enabled = false;
            this.tbIDespecialidad.Location = new System.Drawing.Point(115, 31);
            this.tbIDespecialidad.Name = "tbIDespecialidad";
            this.tbIDespecialidad.Size = new System.Drawing.Size(100, 20);
            this.tbIDespecialidad.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPaciente);
            this.groupBox1.Controls.Add(this.tbIDpaciente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 137);
            this.groupBox1.TabIndex = 20;
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
            // tbIDpaciente
            // 
            this.tbIDpaciente.Enabled = false;
            this.tbIDpaciente.Location = new System.Drawing.Point(105, 31);
            this.tbIDpaciente.Name = "tbIDpaciente";
            this.tbIDpaciente.Size = new System.Drawing.Size(100, 20);
            this.tbIDpaciente.TabIndex = 1;
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
            // buConsulta
            // 
            this.buConsulta.Location = new System.Drawing.Point(266, 104);
            this.buConsulta.Name = "buConsulta";
            this.buConsulta.Size = new System.Drawing.Size(75, 23);
            this.buConsulta.TabIndex = 19;
            this.buConsulta.Text = "Consultar";
            this.buConsulta.UseVisualStyleBackColor = true;
            this.buConsulta.Click += new System.EventHandler(this.buConsulta_Click);
            // 
            // tbIDmedico
            // 
            this.tbIDmedico.Location = new System.Drawing.Point(117, 443);
            this.tbIDmedico.Name = "tbIDmedico";
            this.tbIDmedico.Size = new System.Drawing.Size(171, 20);
            this.tbIDmedico.TabIndex = 18;
            // 
            // tbNroRecibo
            // 
            this.tbNroRecibo.Location = new System.Drawing.Point(137, 104);
            this.tbNroRecibo.Name = "tbNroRecibo";
            this.tbNroRecibo.Size = new System.Drawing.Size(100, 20);
            this.tbNroRecibo.TabIndex = 16;
            this.tbNroRecibo.Leave += new System.EventHandler(this.tbNroRecibo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Médico :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nro. Recibo :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Controls.Add(this.buGrabar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 94);
            this.panel2.TabIndex = 12;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 80);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCESO DE ATENCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Diagnóstico :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tratamiento :";
            // 
            // tbDiagnostico
            // 
            this.tbDiagnostico.Location = new System.Drawing.Point(117, 492);
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.Size = new System.Drawing.Size(353, 20);
            this.tbDiagnostico.TabIndex = 24;
            // 
            // tbTratamiento
            // 
            this.tbTratamiento.Location = new System.Drawing.Point(109, 551);
            this.tbTratamiento.Name = "tbTratamiento";
            this.tbTratamiento.Size = new System.Drawing.Size(661, 20);
            this.tbTratamiento.TabIndex = 25;
            // 
            // buConsultaMedico
            // 
            this.buConsultaMedico.Location = new System.Drawing.Point(330, 440);
            this.buConsultaMedico.Name = "buConsultaMedico";
            this.buConsultaMedico.Size = new System.Drawing.Size(121, 23);
            this.buConsultaMedico.TabIndex = 26;
            this.buConsultaMedico.Text = "Consultar Médico";
            this.buConsultaMedico.UseVisualStyleBackColor = true;
            this.buConsultaMedico.Click += new System.EventHandler(this.buConsultaMedico_Click);
            // 
            // fmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 682);
            this.Controls.Add(this.buConsultaMedico);
            this.Controls.Add(this.tbTratamiento);
            this.Controls.Add(this.tbDiagnostico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buConsulta);
            this.Controls.Add(this.tbIDmedico);
            this.Controls.Add(this.tbNroRecibo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmAtencion";
            this.Text = "fmAtencion";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.TextBox tbIDespecialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPaciente;
        private System.Windows.Forms.TextBox tbIDpaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buConsulta;
        private System.Windows.Forms.TextBox tbIDmedico;
        private System.Windows.Forms.TextBox tbNroRecibo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDiagnostico;
        private System.Windows.Forms.TextBox tbTratamiento;
        private System.Windows.Forms.Button buConsultaMedico;
    }
}