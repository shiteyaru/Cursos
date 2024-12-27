using Exercicio2;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionários serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> lista = new List<Funcionarios>();

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Funcionario #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionarios(id, nome, salario));

            }

            Console.Write("Digite o ID do funcionário que receberá o aumento: ");
            int id_aumento = int.Parse(Console.ReadLine());

                
            Funcionarios func = lista.Find(x => x.Id == id_aumento);
            if (func != null ) {

                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                func.Aumento(porcentagem);

            }
            else {

                Console.WriteLine("Esse ID não existe!!");

            }                
            
            Console.WriteLine($"Lista atualizada de funcionários:");
            foreach (Funcionarios obj in lista) {
                Console.WriteLine(obj);
            }

        }
    }
}