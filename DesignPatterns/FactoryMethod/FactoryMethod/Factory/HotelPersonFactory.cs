using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class EmployerFactory : IHotelPersonFactory
    {
        public HotelPerson CreatePerson(string type)
        {
            switch(type)
            {
                case "Chef": return new Chef();
                case "Cleaner": return new Cleaner();
                case "Receptionist": return new Receptionist();
                case "Guest": return new Guest();
                case "Administrator": return new Administrator();
                default: throw new Exception("Wrong type");
            }
        }
    }
}
