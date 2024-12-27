using Exercicio1.Entities;
using System.Globalization;

namespace Exercicio1 {

    class Course {

        static void Main(string[] args) {

            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"\nTax Payer #{i} Data:");
                Console.Write("Individual or Company (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i') {

                    Console.Write("Health Expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());

                    list.Add(new IndividualPerson(name, anualIncome, healthExp));

                }

                else {

                    Console.Write("Number of Employees: ");
                    int employee = int.Parse(Console.ReadLine());

                    list.Add(new JuridicalPerson(name, anualIncome, employee));

                }

            }

            Console.WriteLine("\n\nTAXES PAID:");

            foreach (Person person in list) {

                Console.WriteLine($"{person.Name}: R${person.Taxes().ToString("F2", CultureInfo.InvariantCulture)}");

            }

            
        }
    }
}