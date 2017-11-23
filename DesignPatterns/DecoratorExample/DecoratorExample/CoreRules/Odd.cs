using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class Odd : IRules
    {
        public int Prize(IEnumerable<int> numbers)
        {
            if (numbers.All(x => x % 2 == 1))
                return 50;
            return 0;
        }
    }
}
