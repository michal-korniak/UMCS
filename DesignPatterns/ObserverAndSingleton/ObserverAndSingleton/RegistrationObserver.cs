using System;

namespace ObserverAndSingleton
{
    internal class RegistrationObserver : ICarObserver
    {
        public RegistrationObserver(ICarObserverable observerable)
        {
            observerable.AddObserver(this);
        }
        public void Update(Car car)
        {
            if (car.RegistrationNumber.Length < 6)
                Console.WriteLine("Rejestracja VIP");
        }
    }
}