using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleAccountingNew.AccountTests
    {
    [TestFixture]
    public class AccountTests
        {
        [Test]
        public void AddTransaction_ShouldAddTransactionToAccount()
            {
            // Arrange
            var account = new CheckingAccount();
            var transaction = new Transaction { Date = DateTime.Now, Description = "Test", Amount = 100m };
            // Act
            account.AddTransaction(transaction);
            // Assert
            Assert.AreEqual(1, account.Transactions.Count);
            Assert.AreEqual(transaction, account.Transactions[0]);
            }
        }


    }
