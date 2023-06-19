using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Serviço : Form
    {
        public Serviço()
        {
            InitializeComponent();     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_computador.Clear();
            tx_cliente.Clear();
            cb_pagamento.ResetText();
            cb_servico.ResetText();
        }

        private void Serviço_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string computador = this.tx_computador.Text;
            string cliente = this.tx_cliente.Text;
            string servicos = this.cb_servico.Text;
            string pagamento = this.cb_pagamento.Text;
        }
    }
}
