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
    public partial class FrInterface_Poupanca : Form
    {
        public FrInterface_Poupanca()
        {
            InitializeComponent();
        }

        Conta ct = new Conta();//instância da conta

        private void button2_Click(object sender, EventArgs e)
        {
            ct._agencia = agencia.Text;
            ct._numero = Convert.ToInt32(conta.Text);
            ct._nome_cliente = cliente.Text;

            MessageBox.Show("Conta Cadastrada com Sucesso!"
                + "\n" +
                "Agência: " + ct._agencia
                + "\n" +
                "Conta: " + ct._numero
                + "\n" +
                "Cliente: " + ct._nome_cliente,
                "Dados do Cliente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorOperacao = Convert.ToDouble(valor.Text);
            if (tip01.Checked == true)
            {
                if ((valorOperacao > ct._saldo) || (ct._saldo < 1))
                {
                    MessageBox.Show("Erro ao Executar a Operação, Saldo Indisponivel!", "Erro");
                }
                else if (ct._saldo > 0)
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
    }
}
