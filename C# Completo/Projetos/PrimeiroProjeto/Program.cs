using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Teste");

            int idade = 36;
            double saldo = 1412.522f;
            string nome = "João";

            Console.WriteLine("Seu nome é: " + nome + "\nSua idade é: " + idade + "\nSeu saldo é: R$" + saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n");
            Console.WriteLine("Seu nome é: {0}\nSua idade é: {1}\nSeu saldo é: R${2}\n", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Seu nome é: {nome}\nSua idade é: {idade}\nSeu saldo é: R${saldo.ToString("F2",CultureInfo.InvariantCulture)}");
            //Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
