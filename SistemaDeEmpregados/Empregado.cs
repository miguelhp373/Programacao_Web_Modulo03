using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEmpregados
{
    class Empregado
    {
        public int id;
        public string nome;
        public double salario;
        public string cargo;
        public double NewValue;

        public void ImprimirDados(int _id, string _nome, double _salario, string _cargo)
        {
            id = _id;
            nome = _nome;
            salario = _salario;
            cargo = _cargo;
        }

        public void AumentarSalario(double percentual, double _salario)
        {
            double porc = percentual / 100;  
            NewValue = _salario * (1 + porc);
            salario =  Math.Round(NewValue,2);
        }
    }
}
