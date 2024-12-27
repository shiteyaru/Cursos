using Exercicio.Entities;

namespace Course {

    class Program {

        static void Main(string[] args) {

            HashSet<User> users = new HashSet<User>();

            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nA; i++) {

                Console.Write($"Student #{i} ID: ");
                int id = int.Parse(Console.ReadLine());
                users.Add(new User(id));

            }

            Console.Write("How many students for course B? ");
            int nB = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nB; i++) {

                Console.Write($"Student #{i} ID: ");
                int id = int.Parse(Console.ReadLine());
                users.Add(new User(id));

            }

            Console.Write("How many students for course C? ");
            int nC = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nC; i++) {

                Console.Write($"Student #{i} ID: ");
                int id = int.Parse(Console.ReadLine());
                users.Add(new User(id));

            }

            Console.WriteLine($"\nTotal students: {users.Count()}");

        }
    }
}
