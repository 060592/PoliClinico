using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AppPostaMedica
{
    public partial class Login : Form
    {
        ArrayList user;
        ArrayList pass;
        public Login()
        {
            InitializeComponent();
            user = new ArrayList();
            pass = new ArrayList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conseguir nombre de usuario
            string username = tblogin_username.Text;
            string password = tblogin_pass.Text;
            //buscar nombre de usuario en la lista
            if (username.Equals("Admin") && password == "admin")
            {
                Hide();
                fmMenu f1 = new fmMenu();                
                f1.Show();
            }
                
        }
    }
}
