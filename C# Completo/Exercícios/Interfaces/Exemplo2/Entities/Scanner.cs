using Exemplo2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2.Entities {
    internal class Scanner : Device, IScanner {

        public override void ProcessDoc(string doc) {
            Console.WriteLine($"ProcessDoc do Scanner: {doc}");
        }

        public string Scan() {
            return "Scan!!!";
        }
    }
}
