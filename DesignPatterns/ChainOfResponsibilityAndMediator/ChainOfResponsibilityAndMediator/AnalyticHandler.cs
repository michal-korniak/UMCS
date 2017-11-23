using System;
using System.Text;

namespace ChainOfResponsibilityAndMediator
{
    public class AnalyticHandler : IHandler
    {
        private IHandler _nextHandler;
        private String _name;

        public AnalyticHandler(string name)
        {
            _name = name;
        }


        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void Execute(ProjectMediator mediator)
        {
            if (mediator.Estimate == 0)
            {
                Console.WriteLine("Projekt musi zostac najpierw zatwierdzony przez szefa");
                return;
            }
            mediator.AddProgress(_name, "Analityk","Wycena",$"Analiza zrobiona");
            _nextHandler.Execute(mediator);
        }
    }
}