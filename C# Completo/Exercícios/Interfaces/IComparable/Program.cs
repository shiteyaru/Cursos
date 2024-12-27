using IComparablee.Entities;
using System;
using System.Linq.Expressions;

namespace Course {
    class Program {

        static void Main(string[] args) {

            string path = @"C:\temp\in.txt";

            using (StreamReader sr = new StreamReader(path)) {

                List<Employee> list = new List<Employee>();

                while (!sr.EndOfStream) {

                    list.Add(new Employee(sr.ReadLine()));

                }

                list.Sort();
                foreach(Employee l in list) {

                    Console.WriteLine(l);
                }

            }          

        }

    }
}