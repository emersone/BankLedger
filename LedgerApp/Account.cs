using System;
using System.Collections.Generic;

namespace LedgerApp
{

    public class Account
    {
        //Create a new list of Transaction objects.
        private List<Transaction> transactionList = new List<Transaction>();
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private double balance;
        private bool loggedIn;


        //Constructor.
        public Account(string username, string password, string firstName, string lastName)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            balance = 0.0;
        }


        //If user chooses to log in with valid inputs, set variable to true.
        public void logIn(string username, string password)
        {
            //If username and password entered are valid, log in user.
            if (this.username.Equals(username) && this.password.Equals(password))
            {
                loggedIn = true;
            }

            //If username or password entered are invalid, do not sign in user.
            else
            {
                loggedIn = false;
            }
        }


        //If user chooses to log out, set loggedIn variable to false.
        public void logOut()
        {
            loggedIn = false;
        }


        //Returns if the user is logged in.
        public Boolean isAccountLoggedIn()
        {
            return loggedIn;
        }


        //Returns balance.
        public double checkBalance()
        {
            return balance;
        }


        //Adds deposit amount to balance and records in transaction history.
        public void recordDeposit(double depositAmount)
        {
            if (!loggedIn)
            {
                throw new Exception("Cannot record a deposit for a logged out account.");
            }

            balance += depositAmount;
            transactionList.Add(new Transaction(depositAmount, Operation.Deposit));
        }


        //Subtracts withdrawal amount from balance and records in transaction history.
        public void recordWithdrawal(double withdrawalAmount)
        {
            if (!loggedIn)
            {
                throw new Exception("Cannot record a withdrawal for a logged out account.");
            }
            balance -= withdrawalAmount;
            transactionList.Add(new Transaction(withdrawalAmount, Operation.Withdrawal));
        }


        //Returns entire transactionList object.
        public List<Transaction> getTransactionHistory()
        {
            if (!loggedIn)
            {
                throw new Exception("Cannot list transactions for a logged out account.");
            }
            return transactionList;
        }


        //Returns transaction history as a single string stored in variable output.
        public string getTransactionHistoryString()
        {
            if (!loggedIn)
            {
                throw new Exception("Cannot provide transaction history for a logged out account.");
            }

            string output = "";

            //Loop through each transaction item in transactionList and append to variable output.
            foreach (var transaction in transactionList)
            {
                output = output + transaction.toString() + '\n';
            }

            return output;
        }

    }
}

