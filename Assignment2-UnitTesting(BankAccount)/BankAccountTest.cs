using ConceptArchitect.Finance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class BankAccountTest
    {
        /// <summary>
        /// Valid test case for Deposit method 
        /// </summary>
        [TestMethod]
        public void DepositProperTest()
        {
            double amount = 5000.0;
            int accountNumber = 1234567;
            string name = "Test";
            string pswd = "pass";
            double balance = 1000;
            double inte= 10;
            var classObject = new BankAccount(accountNumber, name,pswd,balance,inte);
            var result = classObject.Deposit(amount);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Invalid test case for Deposit method 
        /// </summary>
        [TestMethod]
        public void DepositFailTest()
        {
            double amount = 0.0;
            int accountNumber = 1234567;
            string name = "Test";
            string pswd = "pass";
            double balance = 1000;
            double inte = 10;
            var classObject = new BankAccount(accountNumber, name, pswd, balance, inte);
            var result = classObject.Deposit(amount);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Invalid test case for Deposit method with amount 0
        /// </summary>
        [TestMethod]
        public void WithdrawFailTest()
        {
            double amount = 0.0;
            int accountNumber = 1234567;
            string name = "Test";
            string pswd = "pass";
            double balance = 1000;
            double inte = 10;
            var classObject = new BankAccount(accountNumber, name, pswd, balance, inte);
            var result = classObject.Withdraw(amount,pswd);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Valid test case for Deposit method with amount less than balance
        /// </summary>
        [TestMethod]
        public void WithdrawProperTest()
        {
            double amount = 1000;
            int accountNumber= 1234567;
            string name = "Test";
            string pswd = "pass";
            double balance = 5000;
            double inte = 10;
            var classObject = new BankAccount(accountNumber, name, pswd, balance, inte);
            var result = classObject.Withdraw(amount, pswd);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Invalid test case for Deposit method with wrong password
        /// </summary>
        [TestMethod]
        public void WithdrawWrongPasswordTest()
        {
            double amount = 1000;
            int accountNumber = 1234567;
            string name = "Test";
            string pswd = "pass";
            double balance = 5000;
            double inte = 10;
            var classObject = new BankAccount(accountNumber, name, pswd, balance, inte);
            var result = classObject.Withdraw(amount, "WrongPassword");
            Assert.IsFalse(result);
        }


    }
}
