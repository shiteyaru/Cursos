using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities {
    internal class Contract {


        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; } // Lista de Installments

        public Contract(int number, DateTime date, double contractValue) { 

            Number = number;
            Date = date;
            ContractValue = contractValue;
            Installments = new List<Installment>();

        }

        public void AddInstallment(Installment installment) {

            Installments.Add(installment);

        } // Adiciona o installment na lista


    }
}
