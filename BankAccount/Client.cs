﻿namespace BankAccount
{
    public class Client






    {
        private int v;

        //Fields
        //Properties

        public string LName { get; set; }
        public string FName { get; set; }
        public string AccountNum { get; set; }
        public double AcctBal { get; set; }

        //Constructors

        public Client()
        {
            //defalt constructor
        }


        public Client(string first, string last, string accountNum)
        {
            //overload constructor 3 perameters

            this.FName = first;
            this.LName = last;
            this.AccountNum = accountNum;

        }

        public Client(double acctBal)
        {
            this.AcctBal = acctBal;
        }

        //Methods

        public string GetConstString()
        {            
            string result= "Welcome " + FName +" " + LName + ". Your Acount number is "+ AccountNum ;
            return result;
        }













    }

}