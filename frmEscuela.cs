﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica1;

namespace CAIFGUA2
{
    public partial class frmEscuela : Form
    {
        public frmEscuela()
        {
            InitializeComponent();
        }

        private void FrmFichaUsuario_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
