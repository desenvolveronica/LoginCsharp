﻿using LoginC_.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginC_.Apresentacao
{
    public partial class Cadastre_se : Form
    {
        public Cadastre_se()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfirmarSenha.Text);
            if (controle.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 Form1 = new Form1();
                Form1.Show();
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }
        }
    }
}
