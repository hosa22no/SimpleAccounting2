using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleAccountingNew.Tests
    {
    [TestFixture]
    public class FileManagerTests
        {
        [Test]
        public void LoadTransactions_ShouldLoadTransactionsFromFile()
            {
            // Arrange
            var fileManager = new FileManager();
            // Act
            var transactions = fileManager.LoadTransactions();
            // Assert
            Assert.IsNotNull(transactions);
            }
        [Test]
        public void SaveTransactions_ShouldSaveTransactionsToFile()
            {
            // Arrange
            var fileManager = new FileManager();
            var transactions = new List<Transaction>
                {
                new Transaction { Date = DateTime.Now, Description = "Test", Amount = 100m }
                };
            // Act
            fileManager.SaveTransactions(transactions);
            var loadedTransactions = fileManager.LoadTransactions();
            // Assert
            Assert.AreEqual(1, loadedTransactions.Count);
            Assert.AreEqual("Test", loadedTransactions[0].Description);
            }
        }


    }
