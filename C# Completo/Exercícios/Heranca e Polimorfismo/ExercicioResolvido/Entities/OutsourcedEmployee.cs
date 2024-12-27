using System.Xml.Linq;

namespace ExercicioResolvido.Entities {
    internal class OutsourcedEmployee : Employee {

        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addicionalCharge) : base(name, hours, valuePerHour) {

            AdditionalCharge = addicionalCharge;

        }

        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}
