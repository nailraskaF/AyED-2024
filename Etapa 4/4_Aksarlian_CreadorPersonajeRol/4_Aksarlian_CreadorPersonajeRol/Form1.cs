using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Aksarlian_CreadorPersonajeRol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string invisivilidad;
        string fuerza;
        string curacion;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = text_n.Text;
            string raza = text_r.Text;
            string vida = text_v.Text;
            if (invs.Checked == true)
            {
                invisivilidad = "invisivilidad ";
            }
            if (frz.Checked == true)
            {
                fuerza = "fuerza ";
            }
            if (cur.Checked == true)
            {
                curacion = "curacion ";
            }
            Form2 form2 = new Form2(text_v.Text, text_r.Text, text_n.Text, fuerza, invisivilidad, curacion);
            form2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void text_v_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
