using System;
using System.Text;

namespace ChainOfResponsibilityAndMediator
{
    public class ChefHandler: IHandler
    {
        private IHandler _nextHandler;
        private readonly string _name;

        public ChefHandler(string name)
        {
            _name = name;
        }


        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void Execute(ProjectMediator mediator)
        {
            mediator.Estimate = new Random().Next(100, 1000);
            mediator.AddProgress(_name, "Szef","Wycena",$"Wyceniam na {mediator.Estimate}");
            _nextHandler.Execute(mediator);
        }
    }
}