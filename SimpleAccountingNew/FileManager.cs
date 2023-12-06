using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccountingNew
    {
    public class FileManager
        {
        private readonly string _filePath = "accountData.txt";
        public List<Transaction> LoadTransactions()
            {
            var transactions = new List<Transaction>();
            try 
                { 
            if (File.Exists(_filePath))
                {
                var lines = File.ReadAllLines(_filePath);
                foreach (var line in lines)
                    {
                    var data = line.Split(',');
                    var transaction = new Transaction
                        {
                        Date = DateTime.Parse(data[0]),
                        Description = data[1],
                        Amount = decimal.Parse(data[2])
                        };
                    transactions.Add(transaction);
                    }
                }
                }
            catch (Exception ex) 
                {
                Console.WriteLine($"Ett fel inträade vid inläsning av data: {ex.Message}");
                }
            return transactions;
            }
        public void SaveTransactions(List<Transaction> transactions)
            {
            try { 
            var lines = transactions.Select(t => $"{t.Date},{t.Description},{t.Amount}").ToArray();
            File.WriteAllLines(_filePath, lines);
                }
            catch (Exception ex)
                {
                Console.WriteLine($"Ett fel inträffade vid sparande av data: {ex.Message}");
                }
            }







        }


    }
