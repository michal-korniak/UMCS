using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IChainHandler handler1=new ErrorHandler();
            IChainHandler handler2=new WarringHandler();
            IChainHandler handler3=new UnknownErrorHandler();
            IChainHandler handler4=new InfoHandler();

            handler1.SetNextChain(handler2);
            handler2.SetNextChain(handler3);
            handler3.SetNextChain(handler4);

            Message message =handler1.Register("Mich", "daw@o2.pl", "4111111111111111111");
            Console.WriteLine($"{message.number}: {message.info}");
        }
    }
}
