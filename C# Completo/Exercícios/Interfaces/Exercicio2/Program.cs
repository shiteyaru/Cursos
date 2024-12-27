using Exercicio2.Entities;
using Exercicio2.Services;

namespace Course {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("ENTER CONTRACT DATA");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);
            

            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
}
