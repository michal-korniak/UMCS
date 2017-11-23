namespace ChainOfResponsibilityAndMediator
{
    public interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void Execute(ProjectMediator mediator);
    }
}