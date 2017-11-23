using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAndSingleton
{
    class BankQueue     //invoker
    {
        static BankQueue instance;
        private BankQueue()
        {
            Transactions = new Queue<ICommand>();
        }
        public static BankQueue GetInstance()
        {
            if (instance == null)
                instance = new BankQueue();
            return instance;
        }

        public Queue<ICommand> Transactions { get; set; }


        public void AddTransactions(ICommand transaction)
        {
            Transactions.Enqueue(transaction);
        }
        public void DoAllTransactions()
        {
            while(Transactions.Count()!=0)
            {
                ICommand command= Transactions.Dequeue();
                command.Execute();
            }
        }
    }
}
