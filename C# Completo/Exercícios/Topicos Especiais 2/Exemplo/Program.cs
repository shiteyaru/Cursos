namespace Course {

    class Program {

        static void Main(string[] args) {

            DateTime dt = new DateTime(2024, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string teste = "Lorem ipsum dolor sit amet consecetur elit adisciciping";
            string testeCut = teste.Cut(10);
            Console.WriteLine(teste.Cut(10));


        }
    }
}