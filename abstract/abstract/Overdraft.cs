using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    class Overdraft:Account
    {
        public int Limit { get; set; }
        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance, double Openingbalance) : base(accName, accNo, balance)
        {
            Limit = Limit;
        }
        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("account credited " + amount + " and updated is "  +Balance);
        }
        public override void Withdraw(double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;
                //Console.WriteLine("account debited {o} and updated balance {1}", amount, Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance:" + (Balance + Limit));
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;
                a.Balance += amount;
                //Console.WriteLine("account debited {o} ,updated balance {1} and credited account: {2} {3}", amount, a.AccName, a.AccNo, Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance:" + (Balance + Limit));
            }
        }
        

    }
}
