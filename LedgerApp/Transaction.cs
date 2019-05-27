using System;
using System.Collections.Generic;
using System.Text;

namespace LedgerApp
{
    //Enum to hold two banking operation options.
    public enum Operation { Deposit, Withdrawal };


    public class Transaction
    {
        private double amount;
        private Operation _op;


        //Constructor.
        public Transaction(double amount, Operation op)
        {
            this.amount = amount;
            _op = op;
        }


        //Returns the amount stated for an individual transaction.
        public double getAmount()
        {
            return amount;
        }


        //Returns the banking operation as string.
        public string getOperation()
        {
            return _op.ToString();
        }


        //Converts entire Transation object into a printable string.
        public string toString()
        {
            return String.Format("{0}: {1:C}", _op.ToString(), amount);
        }

    }
}

