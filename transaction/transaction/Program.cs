using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Sender = new Account("NIYA", "7578728", 700.80f);
            Account Receiver = new Account("SIYA", "450078728", 1000.07f);

            Transaction T1 = new Transaction(Sender, Receiver, 100, "SEND Money");


            
        }
    }
}
