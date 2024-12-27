namespace Course {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\temp\myfolder";
            //string targetPath = @"C:\Users\User\Desktop\teste2.txt";

            try {

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");

                foreach(string folder in folders) {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES:");

                foreach (string f in files) {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(@$"{path}\newfolder");


            }
            catch (IOException e) {

                Console.WriteLine($"An error occurred: {e.Message}");

            }
        }
    }
}