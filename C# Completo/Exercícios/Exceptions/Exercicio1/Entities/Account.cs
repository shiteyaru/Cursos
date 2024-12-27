using Exercicio1.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities {
    internal class Account {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account() {

        }

        public Account(int number, string holder, double balance, double withdrawLimit) {

            if (balance <= 0) {
                throw new DomainException("You have no balance in your account.");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;

        }

        public void Deposit(double amount) {

            Balance += amount;

        }

        public void Withdraw(double amount) {

            if (amount > WithdrawLimit || amount > WithdrawLimit && amount > Balance) {
                throw new WithdrawException("The amount exceeds withdraw limit.");
            }
            else if (amount > Balance) {
                throw new WithdrawException("Not enough balance.");
            }
            

            Balance -= amount;

        }
    }
}
