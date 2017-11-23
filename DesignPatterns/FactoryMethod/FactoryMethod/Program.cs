using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void ShowAvailableRoom(IEnumerable<int> coll)
        {
            foreach (int x in coll)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            IHotelPersonFactory factory = new EmployerFactory();
            HotelPerson p1 = factory.CreatePerson("Chef");
            HotelPerson p2 = factory.CreatePerson("Cleaner");
            HotelPerson p3 = factory.CreatePerson("Guest");
            ShowAvailableRoom(p1.RoomAccess);
            ShowAvailableRoom(p2.RoomAccess);
            ShowAvailableRoom(p3.RoomAccess);
            HotelPerson p4 = factory.CreatePerson("Guest");
            ShowAvailableRoom(p4.RoomAccess);


        }
    }
}
