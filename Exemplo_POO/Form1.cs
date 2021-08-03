using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_POO
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }

        Conta ct = new Conta();//instância da conta

        private void button1_Click(object sender, EventArgs e)
        {
            double valorOperacao = Convert.ToDouble(valor.Text);
            if (tip01.Checked == true)
            {
                if ((valorOperacao > ct.saldo) || (ct.saldo < 1))
                {
                    MessageBox.Show("Erro ao Executar a Operação, Saldo Indisponivel!", "Erro");
                }
                else if (ct.saldo > 0)
                {
                    ct.Saque(valorOperacao);
                    saldo.Text = Convert.ToString(ct.ShowSaldo());
                }
            }

            if (tip02.Checked == true)
            {
                ct.Deposito(valorOperacao);
                saldo.Text = Convert.ToString(ct.ShowSaldo());

                MessageBox.Show("Depósito de R$ " + valorOperacao + " Efetuado com Sucesso!", "info");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ct.agencia = agencia.Text;
            ct.numero = Convert.ToInt32(conta.Text);
            ct.nome_cliente = cliente.Text;

            MessageBox.Show("Conta Cadastrada com Sucesso!"
                + "\n" + 
                "Agência: " + ct.agencia 
                +"\n" +
                "Conta: " + ct.numero 
                +"\n" +
                "Cliente: " + ct.nome_cliente,
                "Dados do Cliente");
        }
    }
}
