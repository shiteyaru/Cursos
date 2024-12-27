﻿using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido {

    class Program {

        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();


            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch.ToString() == "y") {

                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else {

                    list.Add(new Employee(name, hours, valuePerHour));

                }

            }

            Console.WriteLine("\n\nPAYMENTS: ");
            foreach (Employee emp in list) {
                Console.WriteLine($"{emp}");
            }


        }
    }
}
