using Exercicio.Entities;

namespace Exercicio {

    class Course {

        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Product #{i} Data:");
                Console.Write("Common, used or imported (c, u, i)? ");
                char ch = char.Parse(Console.ReadLine());


                switch (ch) {
                    case 'c':
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());

                        Product item = new Product(name, price);
                        list.Add(item);
                        break;

                    case 'u':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine());
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                        item = new UsedProduct(name, price, manufactureDate);

                        list.Add(item);

                        break;

                    case 'i':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine());
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());

                        item = new ImportedProduct(name, price, customsFee);

                        list.Add(item);
                        break;

                    default:
                        
                        break;

                }

            }

            Console.WriteLine("\n\nPRICE TAGS:");

            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }


        }


    }
}
