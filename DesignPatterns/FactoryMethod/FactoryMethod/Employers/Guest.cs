using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Guest: HotelPerson
    {
        static int LastGuestRoom = 0;
        public Guest()
        {
            for (int i = LastGuestRoom+1; i <= 40; ++i)
            {
                if (i == 20 || i == 2 || i == 40 || i == 1 || i == 11 || i == 3 || i == 4)
                    continue;
                _roomAccess.Add(i);
                LastGuestRoom = i;
                 break; 

            }
        }
    }
}
