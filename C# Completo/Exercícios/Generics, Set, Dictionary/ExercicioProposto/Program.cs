using ExercicioProposto.Entities;

namespace Course {

    class Program {

        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            StreamReader sr = new StreamReader(path);
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            while (!sr.EndOfStream) {

                string[] vect = sr.ReadLine().Split(" ");
                string username = vect[0];
                DateTime instant = DateTime.Parse(vect[1]);
                set.Add(new LogRecord(username, instant));

            }

            sr.Close();
            Console.WriteLine($"Total Users: {set.Count()}");

            foreach (LogRecord record in set) {

                Console.WriteLine(record.Username);
                Console.WriteLine(record.Instant);

            }

        }
    }
}
