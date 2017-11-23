using System;

namespace ChainOfResponsibilityAndMediator
{
    public class FrontendHandler : IHandler
    {
        private readonly string _name;
        private IHandler _nextHandler;

        public FrontendHandler(string name)
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
            mediator.AddProgress(_name, "Frontend Dev", "Konstrukcja UI", $"UI zrobione");
        }
    }
}