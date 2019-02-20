namespace AppPostaMedica
{
    partial class taEspecialidad
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
            this.tbIDespecial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buActualizar = new System.Windows.Forms.Button();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreEspecial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCostoAtencion = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIDespecial
            // 
            this.tbIDespecial.Location = new System.Drawing.Point(166, 124);
            this.tbIDespecial.Name = "tbIDespecial";
            this.tbIDespecial.Size = new System.Drawing.Size(335, 20);
            this.tbIDespecial.TabIndex = 10;
            this.tbIDespecial.Leave += new System.EventHandler(this.tbIDespecial_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre Especialidad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Especialidad :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buActualizar);
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Controls.Add(this.buGrabar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 87);
            this.panel2.TabIndex = 7;
            // 
            // buActualizar
            // 
            this.buActualizar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buActualizar.Location = new System.Drawing.Point(293, 27);
            this.buActualizar.Name = "buActualizar";
            this.buActualizar.Size = new System.Drawing.Size(95, 32);
            this.buActualizar.TabIndex = 2;
            this.buActualizar.Text = "Actualizar";
            this.buActualizar.UseVisualStyleBackColor = true;
            this.buActualizar.Click += new System.EventHandler(this.buActualizar_Click);
            // 
            // buSalir
            // 
            this.buSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buSalir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buSalir.Location = new System.Drawing.Point(508, 27);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(105, 32);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = false;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // buGrabar
            // 
            this.buGrabar.BackColor = System.Drawing.Color.White;
            this.buGrabar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buGrabar.Location = new System.Drawing.Point(108, 27);
            this.buGrabar.Name = "buGrabar";
            this.buGrabar.Size = new System.Drawing.Size(101, 32);
            this.buGrabar.TabIndex = 0;
            this.buGrabar.Text = "Grabar";
            this.buGrabar.UseVisualStyleBackColor = false;
            this.buGrabar.Click += new System.EventHandler(this.buGrabar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 76);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPECIALIDAD";
            // 
            // tbNombreEspecial
            // 
            this.tbNombreEspecial.Location = new System.Drawing.Point(174, 204);
            this.tbNombreEspecial.Name = "tbNombreEspecial";
            this.tbNombreEspecial.Size = new System.Drawing.Size(327, 20);
            this.tbNombreEspecial.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Costo Atención :";
            // 
            // tbCostoAtencion
            // 
            this.tbCostoAtencion.Location = new System.Drawing.Point(166, 287);
            this.tbCostoAtencion.Name = "tbCostoAtencion";
            this.tbCostoAtencion.Size = new System.Drawing.Size(335, 20);
            this.tbCostoAtencion.TabIndex = 13;
            // 
            // taEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 446);
            this.Controls.Add(this.tbCostoAtencion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombreEspecial);
            this.Controls.Add(this.tbIDespecial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "taEspecialidad";
            this.Text = "taEspecialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDespecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreEspecial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCostoAtencion;
        private System.Windows.Forms.Button buActualizar;
    }
}