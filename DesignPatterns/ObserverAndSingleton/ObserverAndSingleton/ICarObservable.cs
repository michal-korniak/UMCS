namespace ObserverAndSingleton
{
    interface ICarObserverable
    {
        void AddObserver(ICarObserver carObserver);
        void RemoveObserver(ICarObserver carObserver);
        void NotifyAll(Car car);
    }
}
