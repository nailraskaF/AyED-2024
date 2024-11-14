using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Aksarlian_CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(Edad.Text) >= 19 && opciones.Text == "100.001-200.000" || opciones.Text == "mas de 200.000")
            {
                MessageBox.Show("FELICIDADES PODES RECLAMAR LA BECA");
            }
            else
            {
                MessageBox.Show("NO PODEMOS DARTE LA BECA");
            }
        }
    }
}
