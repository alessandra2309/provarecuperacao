using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provaAposentadoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contribuinte ap = new contribuinte();
            ap.nome = tx_nome.Text;
            ap.cpf = tx_cpf.Text;
            ap.DataNascimento = Convert.ToDouble(tx_dataNascimento.Text);
            ap.sexo = cb_sexo.Text;
            ap.profissao = cb_profissao.Text;
            ap.iniciotrabalho = Convert.ToDouble(tx_DIT.Text);
            double  resulta = Convert.ToDouble(ap.Calcular());
            lb_result.Text = $"Falta {resulta} anos para aposentar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            tx_cpf.Text = "";
            tx_dataNascimento.Text = "";
            cb_sexo.Text = "";
            cb_profissao.Text = "";
            tx_DIT.Text = "";
            lb_result.Text = "";
        }

        private void tx_dataNascimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
