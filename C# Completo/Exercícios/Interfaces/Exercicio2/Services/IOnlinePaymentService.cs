﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Services {
    internal interface IOnlinePaymentService {

        double PaymentFee(double amount);
        double Interest(double amount, int months);

    } // Interface do serviço de pagamento (o serviço contratado pode ser outro)
}
