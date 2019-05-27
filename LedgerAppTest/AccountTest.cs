using Microsoft.VisualStudio.TestTools.UnitTesting;
using LedgerApp;
using System;

namespace LedgerAppTest
{
    [TestClass]

    public class AccountTest
    {
        [TestMethod]
        public void TestLogIn()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");

            Assert.IsTrue(account.isAccountLoggedIn());
        }

        [TestMethod]
        public void TestLogInFailure()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "wrong");

            Assert.IsFalse(account.isAccountLoggedIn());
        }


        [TestMethod]
        public void TestLogOut()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");

            Assert.IsTrue(account.isAccountLoggedIn());
            account.logOut();
            Assert.IsFalse(account.isAccountLoggedIn());
        }

        [TestMethod]
        public void TestRecodrDeposit()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");

            Assert.IsTrue(account.isAccountLoggedIn());
            var balance = account.checkBalance();
            Assert.AreEqual(0.0, balance);
            account.recordDeposit(1.0);
            var newBalance = account.checkBalance();
            Assert.AreEqual(1.0, newBalance);
            var transactionList = account.getTransactionHistory();
            Assert.AreEqual(1, transactionList.Count);
            Assert.AreEqual(1.0, transactionList[0].getAmount());
            Assert.AreEqual(Operation.Deposit.ToString(), transactionList[0].getOperation());

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Cannot record a deposit for a logged out account.")]
        public void TestRecodDepositLoggedOutFailure()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");

            Assert.IsTrue(account.isAccountLoggedIn());
            account.logOut();
            Assert.IsFalse(account.isAccountLoggedIn());
            account.recordDeposit(1.0);
        }


        [TestMethod]
        public void TestRecodrWithdrawal()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");

            Assert.IsTrue(account.isAccountLoggedIn());
            var balance = account.checkBalance();
            Assert.AreEqual(0.0, balance);
            account.recordWithdrawal(1.0);
            var newBalance = account.checkBalance();
            Assert.AreEqual(-1.0, newBalance);
            var transactionList = account.getTransactionHistory();
            Assert.AreEqual(1, transactionList.Count);
            Assert.AreEqual(1.0, transactionList[0].getAmount());
            Assert.AreEqual(Operation.Withdrawal.ToString(), transactionList[0].getOperation());

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Cannot record a withdrawal for a logged out account.")]
        public void TestRecodWithdrawalLoggedOutFailure()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");

            Assert.IsTrue(account.isAccountLoggedIn());
            account.logOut();
            Assert.IsFalse(account.isAccountLoggedIn());
            account.recordWithdrawal(1.0);
        }


        [TestMethod]
        public void TestGetTransactionHistory()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");
            Assert.IsTrue(account.isAccountLoggedIn());

            account.recordWithdrawal(1.0);
            account.recordDeposit(2.4);
            var transactionList = account.getTransactionHistory();
            Assert.AreEqual(2, transactionList.Count);
            Assert.AreEqual(1.0, transactionList[0].getAmount());
            Assert.AreEqual(Operation.Withdrawal.ToString(), transactionList[0].getOperation());
            Assert.AreEqual(2.4, transactionList[1].getAmount());
            Assert.AreEqual(Operation.Deposit.ToString(), transactionList[1].getOperation());
        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "Cannot provide transaction history for a logged out account.")]
        public void TestGetTransactionHistoryLoggedOut()
        {
            var account = new Account("username", "password", "Test", "Testerson");

            account.getTransactionHistory();

        }


        [TestMethod]
        public void TestGetTransactionHistoryString()
        {
            var account = new Account("username", "password", "Test", "Testerson");
            account.logIn("username", "password");
            Assert.IsTrue(account.isAccountLoggedIn());

            account.recordWithdrawal(1.0);
            account.recordDeposit(2.4);
            var transactionString = account.getTransactionHistoryString();
            Assert.AreEqual("Withdrawal: $1.00\nDeposit: $2.40\n", transactionString);
        }



        [TestMethod]
        [ExpectedException(typeof(Exception), "Cannot provide transaction history for a logged out account.")]
        public void TestGetTransactionHistoryStringLoggedOut()
        {
            var account = new Account("username", "password", "Test", "Testerson");

            account.getTransactionHistoryString();

        }
    }
}

