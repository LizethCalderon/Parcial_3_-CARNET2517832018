using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String usuario, contraseña;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, contraseña;
            usuario = txtusuario.Text.TrimEnd();
            contraseña = txtcontraseña.Text.TrimEnd();
            if ((usuario == "Lizeth") && (contraseña== "1234"))
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show(" Usuario o Password incorrectos");
            }
        }


    }
}

