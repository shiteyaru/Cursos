using Exemplo2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2.Entities {
    internal class ComboDevice : Device, IPrinter, IScanner{
        

        public override void ProcessDoc(string doc) {
            Console.WriteLine("COMBO BREAKER");
        }

        public string Scan() {
            return "SCAN COMBO BREAKER";    
        }

        public void Print(string doc) {
            Console.WriteLine($"PRINT FOR COMBO BREAKER: {doc.ToUpper()}");
        }

    }
}
