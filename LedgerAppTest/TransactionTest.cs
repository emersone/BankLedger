using Microsoft.VisualStudio.TestTools.UnitTesting;
using LedgerApp; 

namespace BankLedgerTest
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void TestTransactionCreation()
        {
            var t = new Transaction(1.1, Operation.Deposit);
            Assert.AreEqual(1.1, t.getAmount());
        }

        [TestMethod]
        public void TestGetOperation()
        {
            var t = new Transaction(1.1, Operation.Deposit);
            Assert.AreEqual("Deposit", t.getOperation());
        }

        [TestMethod]
        public void TestToString()
        {
            var t = new Transaction(1.1, Operation.Deposit);
            Assert.AreEqual("Deposit: $1.10", t.toString());
        }
    }
}

