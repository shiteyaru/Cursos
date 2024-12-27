using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1.Services {
    internal class ChinaTaxService : ITaxService {

        public double Tax(double amount) {
            if (amount <= 100.0) {
                return amount * 1.1;
            }
            else {
                return amount * 1.5;
            }
        }

    }
}
