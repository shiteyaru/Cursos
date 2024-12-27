using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities {
    internal class Installment {

        public DateTime DueDate { get; set; } // Data devida
        public double Amount { get; set; }



        public Installment(DateTime dueDate, double amount) {

            DueDate = dueDate;
            Amount = amount;

        }

        public override string ToString() {
            return $"{DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)} - {Amount}";
        }
    }
}
