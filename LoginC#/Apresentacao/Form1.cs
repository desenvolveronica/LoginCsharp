﻿using LoginC_.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastre_se cadastro = new Cadastre_se();
            cadastro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
