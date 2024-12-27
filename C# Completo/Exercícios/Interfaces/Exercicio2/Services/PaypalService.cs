using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Services {
    internal class PaypalService : IOnlinePaymentService { // O PaypalService é um PaymentService

        //Regra de negócio
        
        private double _simpleInterest = 0.01;
        private double _monthlyInterest = 0.02;

        public double Interest(double amount, int months) {
            
            return amount * _simpleInterest * months;

        }

        public double PaymentFee(double amount) {

            return amount * _monthlyInterest;

        }
    } 
}
