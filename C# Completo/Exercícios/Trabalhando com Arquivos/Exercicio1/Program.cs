using Exercicio1.Entities;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string path = $@"c:\temp\prod.txt";
            string destination = $@"c:\temp\summary.txt";

            List<Product> list = new List<Product>();

            try {

                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sr = File.AppendText(destination)) {

                    foreach (string line in lines) {

                        string[] separator = line.Split(", ");
                        string name = separator[0];
                        double price = double.Parse(separator[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(separator[2]);

                        list.Add(new Product(name, price, quantity));

                    }

                    foreach (Product product in list) {

                        sr.WriteLine($"{product.Name}, {product.GetPrice().ToString("F2", CultureInfo.InvariantCulture)}");

                    }
                    

                }

            }

            catch (IOException e) {
                Console.WriteLine("An error occurred: " + e.Message);
            }

        }

    }
}
