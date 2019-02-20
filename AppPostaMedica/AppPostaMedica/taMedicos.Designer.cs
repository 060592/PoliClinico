namespace AppPostaMedica
{
    partial class taMedicos
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
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbIDmedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buActualizar = new System.Windows.Forms.Button();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbIDespecial = new System.Windows.Forms.TextBox();
            this.buConsulta = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(166, 182);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(297, 20);
            this.tbAP.TabIndex = 19;
            // 
            // tbIDmedico
            // 
            this.tbIDmedico.Location = new System.Drawing.Point(166, 124);
            this.tbIDmedico.Name = "tbIDmedico";
            this.tbIDmedico.Size = new System.Drawing.Size(297, 20);
            this.tbIDmedico.TabIndex = 18;
            this.tbIDmedico.Leave += new System.EventHandler(this.tbIDmedico_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido Paterno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Médico :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buActualizar);
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Controls.Add(this.buGrabar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 75);
            this.panel2.TabIndex = 15;
            // 
            // buActualizar
            // 
            this.buActualizar.Location = new System.Drawing.Point(305, 27);
            this.buActualizar.Name = "buActualizar";
            this.buActualizar.Size = new System.Drawing.Size(90, 32);
            this.buActualizar.TabIndex = 2;
            this.buActualizar.Text = "ACTUALIZAR";
            this.buActualizar.UseVisualStyleBackColor = true;
            this.buActualizar.Click += new System.EventHandler(this.buActualizar_Click);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 76);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÉDICOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Apellido Materno :";
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(168, 229);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(295, 20);
            this.tbAM.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID Especialidad :";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(168, 281);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(295, 20);
            this.tbNombres.TabIndex = 24;
            // 
            // tbIDespecial
            // 
            this.tbIDespecial.Location = new System.Drawing.Point(168, 325);
            this.tbIDespecial.Name = "tbIDespecial";
            this.tbIDespecial.Size = new System.Drawing.Size(160, 20);
            this.tbIDespecial.TabIndex = 25;
            // 
            // buConsulta
            // 
            this.buConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buConsulta.Location = new System.Drawing.Point(370, 323);
            this.buConsulta.Name = "buConsulta";
            this.buConsulta.Size = new System.Drawing.Size(75, 23);
            this.buConsulta.TabIndex = 26;
            this.buConsulta.Text = "Consultar";
            this.buConsulta.UseVisualStyleBackColor = false;
            this.buConsulta.Click += new System.EventHandler(this.buConsulta_Click);
            // 
            // taMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 456);
            this.Controls.Add(this.buConsulta);
            this.Controls.Add(this.tbIDespecial);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAP);
            this.Controls.Add(this.tbIDmedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "taMedicos";
            this.Text = "taMedicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbIDmedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbIDespecial;
        private System.Windows.Forms.Button buConsulta;
        private System.Windows.Forms.Button buActualizar;
    }
}