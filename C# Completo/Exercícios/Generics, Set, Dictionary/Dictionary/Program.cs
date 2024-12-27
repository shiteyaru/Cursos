namespace Course {
    class Program {

        static void Main(string[] args) {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {

                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream) {

                    string[] vect = sr.ReadLine().Split(", ");
                    string name = vect[0];
                    int votes = int.Parse(vect[1]);



                    if (dictionary.ContainsKey(name)) {

                        dictionary[name] += votes;

                    }
                    else {

                        dictionary.Add(name, votes);

                    }

                }

                foreach (KeyValuePair<string, int> user in dictionary) {

                    Console.WriteLine($"{user.Key}: {user.Value}");

                }
            } catch (IOException e) {

                Console.WriteLine($"An error occurred: {e.Message}");
            }

        }
    }
}