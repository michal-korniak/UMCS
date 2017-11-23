using System;
using System.Text;

namespace ChainOfResponsibilityAndMediator
{
    public class ProgrammerHandler : IHandler
    {
        private IHandler _nextHandler;
        private String _name;

        public ProgrammerHandler(string name)
        {
            _name = name;
        }


        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void Execute(ProjectMediator mediator)
        {
            if (mediator.Estimate==0)
            {
                Console.WriteLine("Projekt musi zostac najpierw zatwierdzony przez szefa");
                return;
            }
            mediator.AddProgress(_name, "Programista","Oprogramowanie",$"Kod napisany");
            _nextHandler.Execute(mediator);
        }
    }
}