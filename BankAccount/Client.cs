namespace BankAccount
{
    public class Client






    {
        //Fields
        //Properties

        public string LName { get; set; }
        public string FName { get; set; }
        public string AccountNum { get; set; }

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

        //Methods

        public string GetConstString()
        {            
            string result= "Welcome " + FName +" " + LName + ". Your Acount number is "+ AccountNum ;
            return result;
        }












    }

}