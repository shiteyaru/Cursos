using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    internal class ConversorDeMoeda {

        public static double ValorDolar;
        public static double QuantDolar;
        
        public static double ValorTotal() {
            return ValorDolar * (QuantDolar + (QuantDolar * 6 / 100) );
        }

    }
}
