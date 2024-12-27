using Exercicio2;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{conta}");
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine($"Dados da conta atualizados: \n{conta}");
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine($"Dados da conta atualizados: \n{conta}");

        }
    }
}
