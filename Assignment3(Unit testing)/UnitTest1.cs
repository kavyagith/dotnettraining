using Bank;
using NUnit.Framework;
using System;

namespace BankTest
{
    public class Tests
    {
        public string username;
        public string password;
        public string accountNumber;
        public double balance;

       [SetUp]
        public void Setup()
        {
             username = "TestUsername";
             password="TestPassword";
             accountNumber = "TestAccountNumber";
             balance = 5000;
        }
        
        [Test]
        public void ValidWithDrawTest()
        {
            var classObject = new BankAcc(username,password, accountNumber, balance);
            var result = classObject.Withdraw(username, password, accountNumber);
            Assert.IsNotNull(result);
        }

        [Test]
        public void InValidWithDrawInvalidUsernameTest()
        {
            string user = "Test";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(()=>classObject.Withdraw(user, password, accountNumber));
        }
        [Test]
        public void InValidWithDrawWithInvalidPasswordTest()
        {

            string pwd = "pswd";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Withdraw(username, pwd, accountNumber));
        }

        [Test]
        public void InValidWithDrawWithInvalidAccountNumberTest()
        {
            string accNumb = "123";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Withdraw(username, password, accNumb));
        }

        [Test]
        public void ValidDepositTest()
        {
            var classObject = new BankAcc(username, password, accountNumber, balance);
            var result = classObject.Deposit(username, password, accountNumber);
            Assert.IsNotNull(result);
        }

        [Test]
        public void InValidDepositWithInvalidUsernameTest()
        {
            string user = "Test";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Deposit(user, password, accountNumber));
        }

        [Test]
        public void InValidDepositWithInvalidPasswordTest()
        {
            string pwd = "pswd";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Deposit(username, pwd, accountNumber));
        }

        [Test]
        public void InValidDepositWithInvalidAccountNumberTest()
        {
            string accNumb = "123";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Deposit(username, password, accNumb));
        }

        [Test]
        public void CreateAccountTest()
        {
            var classObject = new BankAcc(username, password, accountNumber, balance);
            var result = classObject.CreateAccount();
            Assert.AreEqual(result,true);
        }

        [Test]
        public void ValidLogoutTest()
        {
            var classObject = new BankAcc(username, password, accountNumber, balance);
            var result = classObject.Logout(username, password, accountNumber);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void InValidLogoOutWithInvalidUsernameTest()
        {
            string user = "Test";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Logout(user, password, accountNumber));
        }

        [Test]
        public void InValidLogouttWithInvalidPasswordTest()
        {
            string pwd = "pswd";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Logout(username, pwd, accountNumber));
        }

        [Test]
        public void InValidLogoutWithInvalidAccountNumberTest()
        {
            string accNumb = "123";
            var classObject = new BankAcc(username, password, accountNumber, balance);
            Assert.Throws<InvalidOperationException>(() => classObject.Logout(username, password, accNumb));
        }
    }
}