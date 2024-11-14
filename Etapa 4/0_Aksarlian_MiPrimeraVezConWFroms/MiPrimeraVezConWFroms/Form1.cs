using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraVezConWFroms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void farenheit_Click(object sender, EventArgs e)
        {
            farenheit.Text = (int.Parse(temperatura.Text) * 18 / 10 + 32).ToString() + "°F";
        }

        private void Kelvin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            farenheit.Text = (int.Parse(temperatura.Text) * 18 / 10 + 32).ToString() + "°F";
            Kelvin.Text = (int.Parse(temperatura.Text) + 273).ToString() + "°K";
        }
    }
}
