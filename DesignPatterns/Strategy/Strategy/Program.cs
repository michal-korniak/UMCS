using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer t1 = new TaxPayer(new LegalPerson(2000), 22000);
            TaxPayer t2 = new TaxPayer(new CorporatePerson(30000), 200000);
            TaxPayer t3 = new TaxPayer(new Mariage(5000, 6), 12000);
            Console.WriteLine(t1.PerformTaxPayment());
            Console.WriteLine(t2.PerformTaxPayment());
            Console.WriteLine(t3.PerformTaxPayment());
        }
    }
}