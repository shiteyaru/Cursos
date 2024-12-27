using MetodosAbs.Entities;
using MetodosAbs.Entities.Enums;
using System.Globalization;

namespace MetodosAbs {

    class Program {

        static void Main(string[] args){

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"\nShape #{i} Data");
                Console.Write("Rectangle or Circle (c/r): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r') {

                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, height, color));

                }

                else if (ch == 'c') {

                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(radius, color));

                }

            }

            Console.WriteLine("\n\nSHAPE AREAS");

            foreach (Shape shape in list) {

                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

            }


        }
    }
}