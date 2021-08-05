using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_POO
{
    class ContaCorrente : Conta
    {
        public void CobrancaServicos(double valor)
        {
            saldo -= valor;
        }
    }
}
