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
        protected int numero;
        public int _numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        protected string agencia;
        public string _agencia {
            get
            {
                return agencia;
            }

            set
            {
                agencia = value;
            }

        }

        protected string nome_cliente;
        public string _nome_cliente
        {
            get
            {
                return nome_cliente;
            }

            set
            {
                nome_cliente = value;
            }
        }

        protected double saldo;
        public double _saldo;

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
            _saldo = saldo;
            return Math.Round(_saldo, 2);
        }

    }
}
