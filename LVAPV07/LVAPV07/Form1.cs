﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAPV07
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void btnLlevar_Click(object sender, EventArgs e)
        {
            frmDos frmForma2 = new frmDos();
            frmForma2.Show();
        }

        private void lblForma1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLlevamefrm3_Click(object sender, EventArgs e)
        {
            frmTres frmForma3 = new frmTres();
            frmForma3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
