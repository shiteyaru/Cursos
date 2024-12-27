﻿using Exercicio1;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quartos; i++) {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("E-mail:");
                string email = Console.ReadLine();
                Console.Write("Quarto:");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Estudante(nome, email);

            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }


        }
    }
}