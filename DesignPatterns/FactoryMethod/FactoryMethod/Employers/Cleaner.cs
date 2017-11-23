using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Cleaner : HotelPerson
    {
        public Cleaner()
        {
            for (int i = 1; i <= 40; ++i)
            {
                if (i == 20 || i == 2 || i == 40 || i == 1)
                    continue;
                _roomAccess.Add(i);

            }
        }
    }
}
