using System.Collections.Generic;

namespace ObserverAndSingleton
{
    public class Car
    {
        public Car(string city, string name, string registrationNumber)
        {
            City = city;
            Name = name;
            RegistrationNumber = registrationNumber;
        }

        public string City { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }

    }
}