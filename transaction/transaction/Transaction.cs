using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction
{
    class Transaction
    {
        Account Sender;
        Account Receiver;
        
        private string AdditionInfo;

        public Transaction() { }
        public Transaction(string additioninfo)
        {
            this.AdditionTnfo = additioninfo;
        }

        


    }
}
