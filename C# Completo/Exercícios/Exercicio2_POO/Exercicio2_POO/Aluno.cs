using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_POO {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double SomarNotas() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Verificador() {
            if (SomarNotas() < 60) {
                return "Reprovado";
            }
            else {
                return "Aprovado";
            }
        }
    }
}
