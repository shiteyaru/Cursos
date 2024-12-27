using Exemplo1.Services;

namespace Course {
    class Program {

        static void Main(string[] args) {

            PrintService printService = new PrintService();

            Console.Write("How Many Values: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++) {

                int value = int.Parse(Console.ReadLine());
                printService.AddValue(value);
                

            }

            Console.Write($"\nList: ");
            printService.Print();
            Console.WriteLine($"\nFirst: {printService.First()}");

        }
    }
}