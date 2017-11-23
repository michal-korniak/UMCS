using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IRules competition = new MoreThanSeven(new FirstAndLastEqualsZero(new Odd()));
            Console.WriteLine(competition.Prize(new List<int>() { 0, 63, 21, 55, 29, 77, 11, 0 }));
        }
    }
}
