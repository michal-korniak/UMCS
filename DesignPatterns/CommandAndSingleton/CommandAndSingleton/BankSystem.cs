using System;

namespace CommandAndSingleton
{
    class BankSystem
    {
        public void SendMoney(BankAccount sender,BankAccount recipient, double amount) //receiver
        {
            Console.WriteLine($"From {recipient.Number} to {sender.Number}: ${amount}");
            //if (sender.Saldo > amount)
            //    throw new Exception("Sender has not enough money");
            //sender.Saldo -= amount;
            //recipient.Saldo += amount;
        }
    }
}
