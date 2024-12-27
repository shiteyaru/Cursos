using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2 {
    internal class Funcionarios {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem) {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString() {
            return $"{Id}, {Nome}, R${Salario.ToString("F2")}";
        }
    }


}
