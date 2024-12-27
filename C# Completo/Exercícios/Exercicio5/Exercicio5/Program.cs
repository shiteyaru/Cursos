using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            



            /*
            
            LINHAS E COLUNAS POTÊNCIA
            
            Console.WriteLine("Digite o número:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                double quad = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);
                Console.WriteLine($"{i} {quad} {cubo}");
            }
            
            CALCULAR DIVISORES
            
            Console.WriteLine("Digite o número:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i ==0) {
                    Console.WriteLine(i);
                }
            }
            
            
           CALCULAR FATORIAL
            
           Console.WriteLine("Vamos calcular o fatorial de 3 números! Digite um por vez e descubra!");
           int rep = 1;

           while (rep <= 3) {

               Console.WriteLine("Digite o número:");
               int n = int.Parse(Console.ReadLine());
               int total = n;

               while (n > 1) {

                   n -= 1;
                   total *= n;

               }
               Console.WriteLine(total);
               rep++;
           }
                
                
            QUANT DIVISÕES
            
            Console.WriteLine("Digite a quantidade de vezes que deseja fazer divisões:");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, faça as divisões (exemplo: 12/4)");
            double resultado = 0;

            for (int x = 1; x <= quant; x++) {
                string[] numeros = Console.ReadLine().Split("/");

                double n1 = double.Parse(numeros[0]);
                double n2 = double.Parse(numeros[1]);

                if (n2 == 0) {
                    Console.WriteLine("Divisão impossível");
                }
                else {
                    resultado = n1 / n2;
                    Console.WriteLine(resultado);
                }

            }


            
            QUANT. MEDIA
            
            Console.Write("Digite a quantidade de vezes que deseja fazer médias: ");
            int n = int.Parse(Console.ReadLine());
            double media = 0;

            for (int x = 1; x <= n; x++) {
                string[] numeros = Console.ReadLine().Split(" ");

                double n1 = double.Parse(numeros[0]);
                double n2 = double.Parse(numeros[1]);
                double n3 = double.Parse(numeros[2]);

                media = (n1 + n2 + n3) / 3;
                Console.WriteLine($"Media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            
           
            
             
            
            IN E OUT
            
            Console.Write("Digite a quantidade de valores que deseja inserir: ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int repeat=1; repeat <= n; repeat++) {
                Console.Write($"Valor #{repeat}: ");
                int x = int.Parse(Console.ReadLine());
                
                if (x >= 10 && x <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in\n" +
                              $"{fora} out");
            
            
            
            
            MOSTRAR ÍMPARES
            
            Console.WriteLine("Digite um valor inteiro:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            } */
        }
    }
}