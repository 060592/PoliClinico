namespace AppPostaMedica
{
    partial class fmMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tABLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.atenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.médicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.historiaClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.médicosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.historiaClínicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.análisisEconómicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConexionBD = new System.Data.OleDb.OleDbConnection();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tABLASToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.cONSULTASToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tABLASToolStripMenuItem
            // 
            this.tABLASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.médicosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.pacientesToolStripMenuItem});
            this.tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            this.tABLASToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tABLASToolStripMenuItem.Text = "TABLAS";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.médicosToolStripMenuItem.Text = "Médicos";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoAtenciónToolStripMenuItem,
            this.toolStripMenuItem3,
            this.atenciónToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // pagoAtenciónToolStripMenuItem
            // 
            this.pagoAtenciónToolStripMenuItem.Name = "pagoAtenciónToolStripMenuItem";
            this.pagoAtenciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagoAtenciónToolStripMenuItem.Text = "Pago Atención";
            this.pagoAtenciónToolStripMenuItem.Click += new System.EventHandler(this.pagoAtenciónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // atenciónToolStripMenuItem
            // 
            this.atenciónToolStripMenuItem.Name = "atenciónToolStripMenuItem";
            this.atenciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atenciónToolStripMenuItem.Text = "Atención";
            this.atenciónToolStripMenuItem.Click += new System.EventHandler(this.atenciónToolStripMenuItem_Click);
            // 
            // cONSULTASToolStripMenuItem
            // 
            this.cONSULTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.médicosToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.pacientesToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.historiaClínicaToolStripMenuItem,
            this.toolStripMenuItem8});
            this.cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            this.cONSULTASToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // especialidadToolStripMenuItem1
            // 
            this.especialidadToolStripMenuItem1.Name = "especialidadToolStripMenuItem1";
            this.especialidadToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.especialidadToolStripMenuItem1.Text = "Especialidad";
            this.especialidadToolStripMenuItem1.Click += new System.EventHandler(this.especialidadToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(151, 6);
            // 
            // médicosToolStripMenuItem1
            // 
            this.médicosToolStripMenuItem1.Name = "médicosToolStripMenuItem1";
            this.médicosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.médicosToolStripMenuItem1.Text = "Médicos";
            this.médicosToolStripMenuItem1.Click += new System.EventHandler(this.médicosToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(151, 6);
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            this.pacientesToolStripMenuItem1.Click += new System.EventHandler(this.pacientesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(151, 6);
            // 
            // historiaClínicaToolStripMenuItem
            // 
            this.historiaClínicaToolStripMenuItem.Name = "historiaClínicaToolStripMenuItem";
            this.historiaClínicaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.historiaClínicaToolStripMenuItem.Text = "Historia Clínica";
            this.historiaClínicaToolStripMenuItem.Click += new System.EventHandler(this.historiaClínicaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(151, 6);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem2,
            this.toolStripMenuItem9,
            this.médicosToolStripMenuItem2,
            this.toolStripMenuItem10,
            this.pacientesToolStripMenuItem2,
            this.toolStripMenuItem11,
            this.historiaClínicaToolStripMenuItem1,
            this.toolStripMenuItem12,
            this.análisisEconómicoToolStripMenuItem1});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // especialidadToolStripMenuItem2
            // 
            this.especialidadToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.especialidadToolStripMenuItem2.Name = "especialidadToolStripMenuItem2";
            this.especialidadToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.especialidadToolStripMenuItem2.Text = "Especialidad";
            this.especialidadToolStripMenuItem2.Click += new System.EventHandler(this.especialidadToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(174, 6);
            // 
            // médicosToolStripMenuItem2
            // 
            this.médicosToolStripMenuItem2.Name = "médicosToolStripMenuItem2";
            this.médicosToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.médicosToolStripMenuItem2.Text = "Médicos";
            this.médicosToolStripMenuItem2.Click += new System.EventHandler(this.médicosToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(174, 6);
            // 
            // pacientesToolStripMenuItem2
            // 
            this.pacientesToolStripMenuItem2.Name = "pacientesToolStripMenuItem2";
            this.pacientesToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.pacientesToolStripMenuItem2.Text = "Pacientes";
            this.pacientesToolStripMenuItem2.Click += new System.EventHandler(this.pacientesToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(174, 6);
            // 
            // historiaClínicaToolStripMenuItem1
            // 
            this.historiaClínicaToolStripMenuItem1.Name = "historiaClínicaToolStripMenuItem1";
            this.historiaClínicaToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.historiaClínicaToolStripMenuItem1.Text = "Historia Clínica";
            this.historiaClínicaToolStripMenuItem1.Click += new System.EventHandler(this.historiaClínicaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(174, 6);
            // 
            // análisisEconómicoToolStripMenuItem1
            // 
            this.análisisEconómicoToolStripMenuItem1.Name = "análisisEconómicoToolStripMenuItem1";
            this.análisisEconómicoToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.análisisEconómicoToolStripMenuItem1.Text = "Análisis Económico";
            this.análisisEconómicoToolStripMenuItem1.Click += new System.EventHandler(this.análisisEconómicoToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ConexionBD
            // 
            this.ConexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\ANDREEEE\\BDPostaMedica.accdb";
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 569);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policlínico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tABLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem atenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem análisisEconómicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Data.OleDb.OleDbConnection ConexionBD;
    }
}

