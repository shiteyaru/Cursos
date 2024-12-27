using System;
using System.Globalization;

namespace Exercicio1 {

    class Program {

        static void Main(string[] args) {

            string prod1 = "Computador";
            string prod2 = "Mesa de Escritório";

            byte idade = 30;
            int cod = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine(
                $"Produtos:\n{prod1}, cujo preço é $ {preco1.ToString("F2")} \n{prod2}, cujo preço é $ {preco2} \n" +
                $"Registro: {idade} anos de idade, código {cod} e gênero: {genero}\n" +
                $"Medida com oito casas decimais: {medida.ToString("F8")} \n" +
                $"Arredondado (três casas decimais): {medida.ToString("F3")} \n" +
                $"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)} \n");

        }
    }
}