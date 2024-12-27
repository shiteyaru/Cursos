using Exercicio2_POO;
using System;
using System.Globalization;
using System.Xml;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            while (aluno.Nota1 > 30 || aluno.Nota1 < 0) {
                Console.WriteLine("Nota inválida. Digite outra nota até 30");
                aluno.Nota1 = double.Parse(Console.ReadLine());
            }
            aluno.Nota2 = double.Parse(Console.ReadLine());
            while (aluno.Nota2 > 35 || aluno.Nota2 < 0) {
                Console.WriteLine("Nota inválida. Digite outra nota de 0 a 35");
                aluno.Nota2 = double.Parse(Console.ReadLine());
            }
            aluno.Nota3 = double.Parse(Console.ReadLine());
            while (aluno.Nota3 > 35 || aluno.Nota3 < 0) {
                Console.WriteLine("Nota inválida. Digite outra nota até 35");
                aluno.Nota3 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Nota final = {aluno.SomarNotas()}");

            Console.WriteLine(aluno.Verificador());



            /*
            CALCULAR SALARIO E AUMENTO
            
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func.Salario = double.Parse(Console.ReadLine()); 
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {func}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalrio(porcentagem);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {func}");

         
            CALCULAR AREA DE RETANGULO
            
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Altura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área = {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            */
        }
    }
}