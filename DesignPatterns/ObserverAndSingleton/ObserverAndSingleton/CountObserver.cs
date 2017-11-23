using System;

namespace ObserverAndSingleton
{
    class CountObserver: ICarObserver
    {
        public CountObserver(ICarObserverable observerable)
        {
            observerable.AddObserver(this);
        }
        private int _counter;
        public void Update(Car car)
        {
            if(_counter<10)
                Console.WriteLine("Początkowy samochód");
            _counter++;
        }
    }
}
