﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorveteriaZequinha
{
    public partial class frmPesquisarFuncionarios : Form
    {
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();  
            abrir.Show();
            this.Hide();    
        }
    }
}
