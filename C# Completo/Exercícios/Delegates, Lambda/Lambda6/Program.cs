using Lambda6.Entities;
using System.Globalization;
using System.Linq;

namespace Course { 
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();
            StreamReader sr = File.OpenText(path);

            while (!sr.EndOfStream) {

                string[] vect = sr.ReadLine().Split(", ");
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            double avg =
                (from p in list select p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine($"AVERAGE PRICE: {avg.ToString("F2", CultureInfo.InvariantCulture)}\n");

            IEnumerable<string> names =
                list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string name in names) {
                
                Console.WriteLine(name);

            }
        }
    }
}