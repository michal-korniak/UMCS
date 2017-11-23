using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Receptionist : HotelPerson
    {
        public Receptionist()
        {
            for (int i = 1; i <= 40; ++i)
            {
                if (i == 20 || i == 2 || i == 40 || i == 1 ||i == 3)
                    continue;
                _roomAccess.Add(i);
                
            }
        }
    }
}
