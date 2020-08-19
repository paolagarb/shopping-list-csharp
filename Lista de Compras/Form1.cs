﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            lstLista.Items.Add(item);
            txtItem.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
        }
    }
}


