namespace AppPostaMedica
{
    partial class taPacientes
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
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbIDpaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(168, 325);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(295, 20);
            this.tbDireccion.TabIndex = 37;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(168, 281);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(295, 20);
            this.tbNombres.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Dirección :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nombres :";
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(168, 229);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(295, 20);
            this.tbAM.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Apellido Materno :";
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(166, 182);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(297, 20);
            this.tbAP.TabIndex = 31;
            // 
            // tbIDpaciente
            // 
            this.tbIDpaciente.Location = new System.Drawing.Point(166, 124);
            this.tbIDpaciente.Name = "tbIDpaciente";
            this.tbIDpaciente.Size = new System.Drawing.Size(297, 20);
            this.tbIDpaciente.TabIndex = 30;
            this.tbIDpaciente.Leave += new System.EventHandler(this.tbIDpaciente_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellido Paterno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Paciente :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Controls.Add(this.buGrabar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 87);
            this.panel2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(508, 27);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(105, 32);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // buGrabar
            // 
            this.buGrabar.Location = new System.Drawing.Point(108, 27);
            this.buGrabar.Name = "buGrabar";
            this.buGrabar.Size = new System.Drawing.Size(101, 32);
            this.buGrabar.TabIndex = 0;
            this.buGrabar.Text = "Grabar";
            this.buGrabar.UseVisualStyleBackColor = true;
            this.buGrabar.Click += new System.EventHandler(this.buGrabar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 76);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACIENTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "DNI :";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(166, 367);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(297, 20);
            this.tbDNI.TabIndex = 39;
            // 
            // taPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 501);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAP);
            this.Controls.Add(this.tbIDpaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "taPacientes";
            this.Text = "taPacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbIDpaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button button1;
    }
}