using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities {
    internal class JuridicalPerson : Person {

        public int Employee { get; set; }


        public JuridicalPerson (string name, double anualIncome, int employee) : base (name, anualIncome) {

            Employee = employee;
        }

        public override double Taxes() {
            
            if (Employee > 10) {

                return 0.14 * AnualIncome;

            }

            else {

                return 0.16 * AnualIncome;

            }

        }
    }
}
