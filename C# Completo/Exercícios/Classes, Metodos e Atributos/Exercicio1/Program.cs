using Exercicio1;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual é a cotação do dólar?");
            ConversorDeMoeda.ValorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            ConversorDeMoeda.QuantDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ValorTotal().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}