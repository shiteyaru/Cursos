using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Services {
    internal class PaypalService : IOnlinePaymentService {

        private double MonthlyInterest = 0.01;
        private double FeePercentage = 0.02;

        public double Interest(double amount, int months) {

            return amount * MonthlyInterest * months;

        }

        public double PaymentFee(double amount) {

            return amount * FeePercentage;

        }
    }
}
