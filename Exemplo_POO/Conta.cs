using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_POO
{
    class Conta
    {
        //atributos
        public int    numero;
        public string agencia;
        public string nome_cliente;
        public double saldo;

        //metodos
    public void Saque(double valor)
        {

            if (saldo > 0)
            {
                saldo -= valor;
            }
        }

    public void Deposito(double valor)
        {
            saldo += valor;
        }

        public double ShowSaldo()
        {
            return Math.Round(saldo,2);
        }

    }
}
