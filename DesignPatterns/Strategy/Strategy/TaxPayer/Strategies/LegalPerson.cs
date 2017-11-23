using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class LegalPerson : ITaxStrategy
    {
        public double Rent { get; set; }
        public LegalPerson(double rent)
        {
            Rent = rent;
        }
        private double CalculateRelief()
        {
            if (Rent < 10000)
                return Rent;
            return 10000;
        }
        public double PayTax(double income)
        {
            if (income > 100000)
                return (0.7 * income) - CalculateRelief();
            else
                return (0.85 * income) - CalculateRelief();
        }
    }
}
