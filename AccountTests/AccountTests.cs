using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestFixture]

    public class AccountTests
    {

        /*// leave for later
        [Test]
        public void Test_Client_CTR()
        {
            Test_Client

        }
        */ // leave for later

        [Test]
        public void Test_LName_Prop()
        {
            //arrange
            Client myClient = new Client();

            //action

            myClient.LName = "Doh";
            string response = myClient.LName;

            //assert

            Assert.That(response, Is.EqualTo("Doh"));
        }

        [Test]
        public void Test_FName_Prop()
        {
            //arrange
            Client myClient = new Client();

            //action

            myClient.FName = "John";
            string response = myClient.FName;

            //assert

            Assert.That(response, Is.EqualTo("John"));
        }

        [Test]
        public void Test_AccountNum_Prop()
        {
            //arrange
            Client myClient = new Client();

            //action

            myClient.AccountNum = "0101010";
            string response = myClient.AccountNum;

            //assert

            Assert.That(response, Is.EqualTo("0101010"));
        }

        [Test]
        public void Test_Client_Menu_CTR()
        {
            //arrange
            Client myClient = new Client("John","Doh","0101010");

            //action

            
            string response = myClient.GetConstString();

            //assert

            Assert.That(response, Is.EqualTo("Welcome " + myClient.FName + " " + myClient.LName + ". Your Acount number is " + myClient.AccountNum ));

        }

        [Test]
        public void Test_Account_CTR()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myClient.LName = "Doh";
            string response = myClient.LName;

            //assert

            Assert.That(response, Is.EqualTo("Doh"));
        }



    }
}
