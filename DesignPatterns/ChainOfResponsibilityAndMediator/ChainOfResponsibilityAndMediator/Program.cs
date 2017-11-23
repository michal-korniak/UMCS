namespace ChainOfResponsibilityAndMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IHandler chefHandler = new ChefHandler("Adam Nowak");
            IHandler analyticHandler = new AnalyticHandler("Andrzej Daniluk");
            IHandler programmerHandler = new ProgrammerHandler("Mochi Per");
            IHandler fronendHandler = new FrontendHandler("Marek Parowa");

            chefHandler.SetNextHandler(analyticHandler);
            analyticHandler.SetNextHandler(programmerHandler);
            programmerHandler.SetNextHandler(fronendHandler);

            ProjectMediator mediator = new ProjectMediator();
            chefHandler.Execute(mediator);
            mediator.ShowDevelopProgress();

        }
    }

}
