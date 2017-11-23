using System;

namespace ObserverAndSingleton
{
    internal class CityObserver : ICarObserver
    {
        private int _counter;
        private string _lastCity;

        public CityObserver(ICarObserverable observerable)
        {
            observerable.AddObserver(this);
        }

        public void Update(Car car)
        {
            if (!(_lastCity != null && _lastCity.Equals(car.City)))
            {
                Console.WriteLine($"Nowe miasto numer {++_counter}");
                _lastCity = car.City;
            }
        }
    }
}