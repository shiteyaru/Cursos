using Exercicio1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Services {
    internal class ContractService {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) { 

            _onlinePaymentService = onlinePaymentService;

        }

        public void ProcessContract(Contract contract, int months) {

            double inicialValue = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) { 

                DateTime date = contract.Date.AddMonths(i);
                double updatedValue = inicialValue + _onlinePaymentService.Interest(inicialValue, i);
                double fullValue = updatedValue + _onlinePaymentService.PaymentFee(updatedValue);
                contract.AddInstallment(new Installment(date, fullValue));
            }


        }

    }
}
