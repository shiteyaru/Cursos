using Exemplo2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2.Entities {
    internal class Printer : Device, IPrinter {
        public void Print(string doc) {
            Console.WriteLine($"Print: {doc}");
        }

        public override void ProcessDoc(string doc) {
            Console.WriteLine($"ProcessDoc do Printer: {doc}");
        }
    }
}
