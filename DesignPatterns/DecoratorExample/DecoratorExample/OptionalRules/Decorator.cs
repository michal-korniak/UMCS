using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    abstract class Decorator: IRules
    {
        public abstract int Prize(IEnumerable<int> numbers);
        public Decorator(IRules wrappedObj)
        {
            _wrappedObj = wrappedObj;
        }


        protected IRules _wrappedObj;

    }
}
