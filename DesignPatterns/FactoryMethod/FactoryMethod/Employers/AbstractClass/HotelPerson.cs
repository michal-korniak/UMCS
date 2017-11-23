using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class HotelPerson
    {
        public IEnumerable<int> RoomAccess {
            get
            {
                return _roomAccess;
            }
        }
        protected List<int> _roomAccess=new List<int>();



    }
}
