using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class FirstAndLastEqualsZero : Decorator
    {
        public FirstAndLastEqualsZero(IRules wrappedObj) : base(wrappedObj)
        {

        }

        public override int Prize(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers.First() == 0 && numbers.Last() == 0)
                sum = 100;
            return sum + _wrappedObj.Prize(numbers);
        }
    }
}
