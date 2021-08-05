using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_POO
{
    class Poupanca : Conta
    {
          public void Rendimento(double PercentualRendimento)
        {
            saldo *= 1.002;
        }
    }
}
