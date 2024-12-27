using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_POO {
    internal class Funcionario {

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentarSalrio(double porcentagem) {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString() {
            return $"{Nome}\n${SalarioLiquido()}";
        }
    }
}
