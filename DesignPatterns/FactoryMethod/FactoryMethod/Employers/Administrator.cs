using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Administrator: HotelPerson
    {
        public Administrator()
        {
            for (int i = 1; i <= 40; ++i)
            {
                if (i == 20)
                    continue;
                _roomAccess.Add(i);

            }
        }
    }
}
