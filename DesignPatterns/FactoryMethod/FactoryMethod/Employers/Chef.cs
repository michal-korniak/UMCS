using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Chef : HotelPerson
    {
        public Chef()
        {
            _roomAccess = new List<int>() { 20, 2, 40, 1 };
        }

    }
}
