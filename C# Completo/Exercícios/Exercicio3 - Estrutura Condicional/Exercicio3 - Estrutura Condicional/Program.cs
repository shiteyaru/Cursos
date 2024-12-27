using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {




            /*

           CALCULAR IMPOSTOS
            
           Console.WriteLine("Digite seu salário:");
           double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           double imposto = 0;

           if (salario <= 2000.0) {
               imposto = 0.0;
           }

           else if (salario <= 3000.0) {
               imposto = (salario - 2000.0) * 0.08;
           }

           else if (salario <= 4500.0) {
               imposto = (salario - 3000.0) * 0.18 + 1000 * 0.08;
           }

           else {
               imposto = (salario - 4500.0) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
           }

           if (imposto == 0) {
               Console.WriteLine("ISENTO!");
           }
           Console.WriteLine($"IMPOSTO: R${imposto.ToString(CultureInfo.InvariantCulture)}");





           IDENTIFICAR COORDENADAS

           Console.WriteLine("Digite 2 números (separe-os com espaço) e descubra a posição deles:");
           string[] coordernadas = Console.ReadLine().Split(" ");

           int x = int.Parse(coordernadas[0]);
           int y = int.Parse(coordernadas[1]);

           if(x > 0 && y > 0) {
               Console.WriteLine("Q1");
           }
           else if (x < 0 && y > 0) {
               Console.WriteLine("Q2");
           }
           else if (x < 0 && y < 0) {
               Console.WriteLine("Q3");
           }
           else if (x > 0 && y < 0) {
               Console.WriteLine("Q4");
           }
           else {
               Console.WriteLine("ORIGEM");
           }

           INTERVALOS

           for (int i = 0; i < 4; i++) {

               Console.WriteLine("Digite um número entre 0 e 100:");
               double numero = double.Parse(Console.ReadLine());
               verificarIntervalo();
               void verificarIntervalo() {



                   if (numero < 0 || numero > 100) {
                       Console.WriteLine("NÚMERO FORA DO INTERVALO!");
                   }

                   else if (numero <= 25) {
                       Console.WriteLine("INTERVALO [0, 25]");
                   }

                   else if (numero <= 50) {
                       Console.WriteLine("INTERVALO [25, 50]");
                   }

                   else if (numero <= 75) {
                       Console.WriteLine("INTERVALO [50, 75]");
                   }

                   else {
                       Console.WriteLine("INTERVALO [75, 100]");
                   }


               }

           }

           CALCULAR PREÇOS

           string[] codigos = Console.ReadLine().Split();

           int codigo = int.Parse(codigos[0]);
           int quantidade = int.Parse(codigos[1]);

           double total = 0;
           if (codigo == 1) {
               total = 4 * quantidade;
           }
           else if (codigo == 2) {
               total = 4.5 * quantidade;
           }
           else if (codigo == 3) {
               total = 5 * quantidade;
           }
           else if (codigo == 4) {
               total = 2 * quantidade;
           }
           else {
               total = 1.5 * quantidade;
           }

           Console.WriteLine($"Total: R${total}");




           CALCULAR HORAS

           string[] horarios = Console.ReadLine().Split(" ");
           int hora_inicio = int.Parse(horarios[0]);
           int hora_fim = int.Parse(horarios[1]);

           int duracao = 0;
           if (hora_inicio < hora_fim) {
               duracao = hora_fim - hora_inicio;
           }
           else {
               duracao = 24 - hora_inicio + hora_fim;
           }

           Console.WriteLine($"O jogo durou {duracao} hora(s)");


           VERIFICA MÚLTIPLOS

           Console.WriteLine("Vamos verificar se 2 números são multiplos entre si! \nDigite dois números:");

           string[] numeros = Console.ReadLine().Split();

           int n1 = int.Parse(numeros[0]);
           int n2 = int.Parse(numeros[1]);

           if (n1 % n2 == 0 || n2 % n1 == 0) {
               Console.WriteLine("MÚLTIPLOS");
           }
           else {
               Console.WriteLine("NÃO MÚLTIPLOS");
           }


            VERIFICA PAR/IMPAR E NEGATIVO/POSITIVO

           Console.WriteLine("Digite um número:");
           float numero = float.Parse(Console.ReadLine());

           if (numero < 0) {
               if (numero % 2 == 0) {
                   Console.WriteLine("NEGATIVO E PAR!");
               }

               else {
                   Console.WriteLine("NEGATIVO E ÍMPAR!");
               }

           }
           else {
               if (numero % 2 == 0) {
                   Console.WriteLine("POSITIVO E PAR!");
               }

               else {
                   Console.WriteLine("POSITIVO E ÍMPAR!");
               }
           } */


        }
    }
}