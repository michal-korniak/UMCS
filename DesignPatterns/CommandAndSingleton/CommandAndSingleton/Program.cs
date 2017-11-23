using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAndSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            BankSystem system = new BankSystem();
            BankAccount acc1 = new BankAccount() { ID = 1, Number = 1000, Saldo = 11111 };
            BankAccount acc2 = new BankAccount() { ID = 2, Number = 2000, Saldo = 22222 };
            BankAccount acc3 = new BankAccount() { ID = 3, Number = 3000, Saldo = 1000 };
            BankQueue.GetInstance().AddTransactions(new SendMoney(system, acc1, acc2, 15.20));
            BankQueue.GetInstance().AddTransactions(new SendMoney(system, acc3, acc2, 0.20));
            BankQueue.GetInstance().DoAllTransactions();
        }
    }
}
