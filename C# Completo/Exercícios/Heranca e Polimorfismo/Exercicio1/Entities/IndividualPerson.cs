using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities {
    internal class IndividualPerson : Person {

        public double HealthExp { get; set; }


        public IndividualPerson(string name, double anualIncome, double healthExp) : base (name, anualIncome) {

            HealthExp = healthExp;
        }

        public override double Taxes() {

            if (AnualIncome >= 20000.0) {

                if (HealthExp > 0) {

                    return 0.25 * AnualIncome - (0.5 * HealthExp);

                }
                else {

                    return 0.25 * AnualIncome;

                }

            }

            else {

                if (HealthExp > 0) {

                    return 0.15 * AnualIncome - (0.5 * HealthExp);

                }
                else {

                    return 0.15 * AnualIncome;

                }

            }

        }







    }
}
