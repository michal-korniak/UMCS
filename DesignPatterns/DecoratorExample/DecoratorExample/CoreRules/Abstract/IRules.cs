using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    interface IRules
    {
        int Prize(IEnumerable<int> numbers);
    }
}
