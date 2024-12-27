using Exercicio1.Entities;
using Exercicio1.Entities.Exceptions;

namespace Course {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("\nNumber: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.Withdraw(amount);

                Console.WriteLine($"New Balance: {acc.Balance}");
            }
            catch (DomainException e) {
                Console.WriteLine($"Error in Account: {e.Message}");
            }
            catch (WithdrawException e) {
                Console.WriteLine($"Withdraw Error: {e.Message}");
            }


    }
    }
}