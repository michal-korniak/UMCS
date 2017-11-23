using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CorporatePerson : ITaxStrategy
    {
        public double Rent { get; set; }
        public CorporatePerson(double rent)
        {
            Rent = rent;
        }
        private double CalculateRelief()
        {
            if (Rent < 15000)
                return Rent;
            return 15000;
        }
        public double PayTax(double income)
        {
            return (0.8 * income) - CalculateRelief();
        }
    }
}
