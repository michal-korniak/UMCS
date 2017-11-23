using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Mariage : ITaxStrategy
    {
        public double Rent { get; set; }
        public int NumOfChildren { get; set; }
        public Mariage(double rent, int numOfChildren)
        {
            Rent = rent;
            NumOfChildren = numOfChildren;
        }
        private double CalculateRelief()
        {
            double relief = Rent + 500 * NumOfChildren;
            if (relief < 20000)
                return relief;
            return 20000;
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
