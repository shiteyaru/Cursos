using Exemplo2.Entities;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Printer p = new Printer { SerialNumber = 1001 };
            Scanner s = new Scanner { SerialNumber = 1002 };
            ComboDevice cd = new ComboDevice { SerialNumber = 1003 };

            Console.WriteLine("PRINTER");
            p.Print("oi");
            p.ProcessDoc("oi");

            Console.WriteLine("\nSCANNER");
            s.Scan();
            s.ProcessDoc("oi");

            Console.WriteLine("\nCOMBO BREAKERRRRRRRR");
            cd.Print("oi");
            cd.Scan();
            cd.ProcessDoc("oi");

        }
    }
}