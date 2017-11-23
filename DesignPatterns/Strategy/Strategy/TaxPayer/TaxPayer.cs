using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class TaxPayer
    {
        public ITaxStrategy Strategy { private get; set; }
        public double Income { get; set; }

        public TaxPayer(ITaxStrategy strategy, double income)
        {
            Strategy = strategy;
            Income = income;
        }

        public double PerformTaxPayment()
        {
            return Strategy.PayTax(Income);
        }

    }
}
