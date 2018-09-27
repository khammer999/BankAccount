using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean appRunState = true; //application run state control variable
            //string checkForExit = "null";


            Checking myCheckingAcct = new Checking();
            Client myClientInfo = new Client();
            Savings mySavingsAcct = new Savings();

            Console.WriteLine("TEST Colaborator");
            Console.WriteLine("TEST Colaborator");


            //promt user for Clent Info for UI

            Console.WriteLine("Welcome to Bank Account Please enter Your First Name");
            myClientInfo.FName = Console.ReadLine();

            Console.WriteLine("Welcome to Bank Account Please enter Your Last Name");
            myClientInfo.LName = Console.ReadLine();

            Console.WriteLine("Please enter a desired account number");
            myClientInfo.AccountNum = Console.ReadLine();
            

            do { //Run State Loop

                // display UI
               
                Console.WriteLine();
                Console.WriteLine("< 1 > View Client Information");
                Console.WriteLine();
                Console.WriteLine("< 2 > View Account Balance");
                Console.WriteLine();
                Console.WriteLine("< 3 > Deposit Funds");
                Console.WriteLine();
                Console.WriteLine("< 4 > Withdraw Funds");
                Console.WriteLine();
                Console.WriteLine("< 5 > Exit ");




                // prompt menu response
                int menuSelection = int.Parse(Console.ReadLine());

                //display action and call class methods
                if (menuSelection == 1)
                {
                    // view client info
                    Console.WriteLine("Client Info " + myClientInfo.FName + myClientInfo.LName);
                    Console.WriteLine("Account Number:" + myClientInfo.AccountNum);




                }
                if (menuSelection == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("< a > Checking Account");
                    Console.WriteLine();
                    Console.WriteLine("< b > Savings Account");
                    Console.WriteLine();
                    // prompt sub- menu response
                    string subMenuSelection = Console.ReadLine().ToLower();
                    if (subMenuSelection == "a")
                    {
                        //call checking balance
                        
                        Console.WriteLine(" Checking Account Balance:" + myCheckingAcct.GetBalance());

                        
                                                                                                                                    }
                    if (subMenuSelection == "b")
                    {
                        //call savings balance 
                        Console.WriteLine("Savings Account Balance:" + mySavingsAcct.GetBalance());

                    }

                }
                if (menuSelection == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("< a > Checking Account");
                    Console.WriteLine();
                    Console.WriteLine("< b > Savings Account");
                    Console.WriteLine();
                    // prompt sub- menu response
                    string subMenuSelection = Console.ReadLine().ToLower();
                    if (subMenuSelection == "a")
                    {
                        //call checking balance 
                    }
                    if (subMenuSelection == "b")
                    {
                        //call savings balance 
                    }

                }

                if (menuSelection == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("< a > Checking Account");
                    Console.WriteLine();
                    Console.WriteLine("< b > Savings Account");
                    Console.WriteLine();
                    // prompt sub- menu response
                    string subMenuSelection = Console.ReadLine().ToLower();
                    if (subMenuSelection == "a")
                    {
                        //call checking balance 
                    }
                    if (subMenuSelection == "b")
                    {
                        //call savings balance 
                    }
 
                }

                if (menuSelection == 5)
                {
                    appRunState = false; 
                    
                }







                //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER 

              /*  //EXIT PROGRAM OPTION
                Console.WriteLine();
                Console.WriteLine("Do you wish to Exit? Enter \"Yes\" or \"No\"");

                checkForExit = Console.ReadLine();
                checkForExit = checkForExit.ToLower();

                if (checkForExit.Equals("yes"))
                {
                    appRunState = false;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    // good bye message  exit system here !
                }

                //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER
                */

            } while (appRunState);



        }
    }
}
