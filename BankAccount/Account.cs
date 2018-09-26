using System;

namespace BankAccount
{
    public class Account
    {
        public double AcctBal { get; set; }
        public double Deposit { get; set; }
        public int Withdraw { get; set; }
        public string AcctType { get; set; }
        public string AccountNum { get; set; }

        public double GetWithdraw(double amount)
        {

            amount = this.AcctBal-amount;
            return amount;
        }

        public double GetDeposit(double amount)
        {

            amount = amount + this.AcctBal;

            return amount;

        }

        public double GetBalance()
        {
            return this.AcctBal;   
        }



    }
}