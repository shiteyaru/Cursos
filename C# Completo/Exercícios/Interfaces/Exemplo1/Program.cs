using Exemplo1.Entities;
using Exemplo1.Services;
using System.Globalization;

namespace Course {

    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Enter rental data\n");

            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price for hour: ");
            double priceHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price for day: ");
            double priceDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("What country are you in (China = c | Brazil = b)? ");
            char country = char.Parse(Console.ReadLine());

            if (country == 'b') {
                RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());
                rentalService.ProcessInvoice(carRental);
            }
            else {
                RentalService rentalService = new RentalService(priceHour, priceDay, new ChinaTaxService());
                rentalService.ProcessInvoice(carRental);
            }

            Console.WriteLine("\nINVOICE:");

            Console.WriteLine(carRental.Invoice);



        }
    }
}
