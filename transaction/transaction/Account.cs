using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction
{
    class Account
    {
        public string AccName { get; set; }
        public string AccID { get; set; }
        public double AccBalance { get; set; }
        public int TransactionCount { get; set; }

        Transaction[] transactions;
        public Account() { }
        public Account(string accName, string accID, double accbalance)
        {

            AccName = accName;
            AccID = accID;
            AccBalance = accbalance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc: " + AccID);
            Console.WriteLine("Balance: " + AccBalance);
        }

        public void showallTransaction() { }

        public void addTransaction(Account Sender, Account Receiver, double amount)
        {
            foreach (Transaction transactions in transactions)
            {
                this.transactions[TransactionCount++] = transactions;

            }
        }
        public void Deposit(double amount)
        {
            AccBalance += amount;
            Console.WriteLine("credited by {0},balance: {1}", amount, AccBalance);
        }
        virtual public void Withdraw(double amount)
        {
            if (AccBalance < amount)
            {
                AccBalance -= amount;
                Console.WriteLine(" balance {0}", AccBalance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        virtual public void Transfer(Account acc, double amount)
        {
            if (amount < AccBalance)
            {
                AccBalance -= amount;

                Console.WriteLine("balance {0}", AccBalance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

        }
    }
}
   