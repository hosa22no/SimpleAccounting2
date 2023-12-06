using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccountingNew
    {
    public class CheckingAccount : Account
        {
        public override void AddTransaction(Transaction transaction)
            {
            // Logik för att lägga till en transaktion i ett checkkonto
            Transactions.Add(transaction);
            }
        }
   


    }
