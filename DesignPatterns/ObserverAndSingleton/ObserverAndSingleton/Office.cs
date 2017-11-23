using System.Collections.Generic;

namespace ObserverAndSingleton
{
    class Office : ICarObserverable
    {
        public List<Car> Cars { get; set; }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            NotifyAll(car);
        }

        #region Singleton

        private static Office _instance;

        private Office()
        {
            Cars = new List<Car>();
            _cityObservators = new List<ICarObserver>();
        }

        public static Office GetInstance()
        {
            if (_instance == null)
                _instance = new Office();
            return _instance;
        }

        #endregion

        #region IObservable

        private  List<ICarObserver> _cityObservators;

        public void AddObserver(ICarObserver carObserver)
        {
            _cityObservators.Add(carObserver);
        }

        public void RemoveObserver(ICarObserver carObserver)
        {
            _cityObservators.Remove(carObserver);
        }

        public void NotifyAll(Car car)
        {
            foreach (var observer in _cityObservators)
                observer.Update(car);
        }

        #endregion
    }
}