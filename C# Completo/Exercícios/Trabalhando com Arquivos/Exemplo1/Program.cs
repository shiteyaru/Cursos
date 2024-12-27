namespace Course {
    class Program {
        static void Main(string[] args) {

            string sourcePath = @"C:\Users\User\Desktop\teste.txt";
            string targetPath = @"C:\Users\User\Desktop\teste2.txt";

            try {

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {

                    foreach (string line in lines) {

                        sw.WriteLine(line.ToUpper());

                    }

                }
            }
            catch (IOException e) {

                Console.WriteLine($"An error occurred: {e.Message}");

            }

            /*            
            
            TESTE 1

            string path = @"C:\Users\User\Desktop\teste.txt";

            try {

                using (StreamReader sr = new StreamReader(path)) {

                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }


            catch (IOException e) {

                Console.WriteLine($"An error occurred: {e.Message}");
            }


            TESTE 2

            try {
                string caminho = @"C:\Users\User\Desktop\teste.txt";
                //string saida = @"C:\Users\User\Desktop\teste2.txt";


                FileInfo file = new FileInfo(caminho);

                string[] lines = File.ReadAllLines(caminho);

                foreach (string line in lines) {

                    string saida = $@"C:\Users\User\Desktop\teste{line}.txt";
                    file.CopyTo(saida);

                }
            }
            catch (IOException e) {

                Console.WriteLine($"An error acurred: \n{e.Message}");

            }*/
        }
    }
}
