using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Aksarlian_LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "Admin" && password.Text == "Admin12345")
            {
                MessageBox.Show("AUTORIZADO");
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
        }
    }
}
