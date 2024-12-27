using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numerosAleatorios = new Random();

            for (int i = 0; i <= 10; i++)
                Console.WriteLine(numerosAleatorios.Next());



            int x = 0;
            int y = 0;

            while (x < 10 && y < 10)
            {
                x++;
                if (x % 2 == 0)
                {
                    Console.WriteLine(x + " - Par");
                }
                else
                {
                    Console.WriteLine(x + " - Ímpar");
                }



            }
        }

    }
}
