using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAndSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = Office.GetInstance();
            CountObserver countObserver=new CountObserver(office);
            CityObserver cityObserver=new CityObserver(office);
            RegistrationObserver registrationObserver=new RegistrationObserver(office);

            office.AddCar(new Car("Hrubieszow", "Korniak", "LHR19907"));
            office.AddCar(new Car("Hrubieszow", "Kalicki", "LHR120"));
            office.AddCar(new Car("Hrubieszow", "Nowak", "LHR07"));
            office.AddCar(new Car("Hrubieszow", "Walczak", "LHR21"));
            office.AddCar(new Car("Warszawa", "Walczak", "WA521"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA531211"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "W31"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA64"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA5366"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA531343"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA531343"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA531343"));
            office.AddCar(new Car("Warszawa", "Przepiórka", "WA531343"));
            office.AddCar(new Car("Lublin", "Przepiórka", "LB531343"));
            office.AddCar(new Car("Lublin", "Przepiórka", "LB531343"));
            office.AddCar(new Car("Lublin", "Przepiórka", "LB531343"));
            office.AddCar(new Car("Lublin", "Przepiórka", "LB531343"));
            office.AddCar(new Car("Lublin", "Przepiórka", "LB531343"));
            office.AddCar(new Car("Szczecin", "Przepiórka", "LB531343"));


        }
    }
}
