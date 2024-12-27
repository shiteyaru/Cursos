using Exercicio.Entities;
using System.Linq;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter full file output: ");
            string outputFile = Console.ReadLine();
            Console.Write("Enter salary: ");
            double amount = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            try {
                using (StreamReader sr = File.OpenText(path)) {

                    while (!sr.EndOfStream) {

                        string[] vect = sr.ReadLine().Split(", ");
                        string name = vect[0];
                        string email = vect[1];
                        double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));

                    }
                }
            
                using (StreamWriter sw = new StreamWriter(outputFile)) { 

                    sw.WriteLine($"Email of people whose salary is more than {amount}:");
                    
                    
                    var r1 = from p in list where p.Salary > amount select p.Email;
                    foreach (string item in r1) {

                        sw.WriteLine(item);
                        
                    }

                    sw.WriteLine($"\nSum of salary of people whose name starts with 'M': {(from p in list where p.Name[0] == 'M' select p.Salary).Sum()}");

                }

                Console.WriteLine($"Output written to file: {outputFile}");

            } catch (IOException e) {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}