using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class MoreThanSeven : Decorator
    {
        public MoreThanSeven(IRules wrappedObj) : base(wrappedObj)
        {
        }

        public override int Prize(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers.Count()>6)
                sum = 150;
            return sum + _wrappedObj.Prize(numbers);
        }
    }
}
