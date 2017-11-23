using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAndSingleton
{
    class SendMoney: ICommand
    {
        BankSystem _system;
        BankAccount _sender;
        BankAccount _recipent;
        double _saldo;

        public SendMoney(BankSystem system, BankAccount sender, BankAccount recipent, double saldo)
        {
            _system = system;
            _sender = sender;
            _recipent = recipent;
            _saldo = saldo;
        }

        public void Execute()
        {
            _system.SendMoney(_sender, _recipent, _saldo);
        }
    }
}
