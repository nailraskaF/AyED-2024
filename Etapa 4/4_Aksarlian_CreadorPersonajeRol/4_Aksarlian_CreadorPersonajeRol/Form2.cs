﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2(string vida, string raza, string nombre, string fuerza, string invisivilidad, string curacion)
        {
            InitializeComponent();
            name.Text = nombre;
            RAZA.Text = raza;
            VIDA.Text = vida;
            HAB_ESP.Text = fuerza + curacion + invisivilidad;
        }
    }
}