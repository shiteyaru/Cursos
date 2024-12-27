using Exercicio1.Entities;
using Exercicio1.Services;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Course {

    class Program {

        static void Main(string[] agrs) {

            

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("\nINSTALLMENTS:\n");

            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }


        }
    }
}
