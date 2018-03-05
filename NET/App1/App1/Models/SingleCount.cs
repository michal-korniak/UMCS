using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public enum AreaType
    {
        Rectangle,
        Trapezoid
    }
    public class SingleCount
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public AreaType AreaType { get; set; }
        Func<double, double> function;
        public double Area { get; set; }
        public int CalculationNumber { get; set; }
        public int LowestN { get; set; }
        public int HighestN { get; set; }
        public double Error { get; set; }
        public double MinSquareError { get; set; }

        public SingleCount(double x1, double x2, int calculationNumber,
            int lowestN, int highestN, Func<double, double> function, double area, AreaType areaType, double error)
        {
            X1 = x1;
            X2 = x2;
            CalculationNumber = calculationNumber;
            LowestN = lowestN;
            HighestN = highestN;
            this.function = function;
            Area = area;
            AreaType = areaType;
            Error = error;
        }

        public List<double> Zad1()
        {
            List<double> result = new List<double>();
            var random = new Random();
            for(int i=0; i<CalculationNumber; ++i)
            {
                int n = random.Next(LowestN, HighestN);
                double currentArea=CalculateArea(function, n);
                if (Math.Abs(Area / currentArea - 1) * 100 - Error <= 0)
                {
                    result.Add(currentArea);
                }
            }
            return result;
        }
        


        public double CalculateArea(Func<double, double> function,int n)
        {
            
            if (AreaType == AreaType.Rectangle)
                return CalculateRectangleArea(function,n);
            else
                return CalculateTrapezoidArea(function,n);
        }

        private double CalculateTrapezoidArea(Func<double, double> function,int n)
        {
            double h;

            h = (X2 - X1) / (double)n;


            double area = 0;
            for (int i = 1; i < n; i++)
            {
                area += function(X1 + i * h);
            }
            area += function(X1) / 2;
            area += function(X2) / 2;
            area *= h;
            return area;
        }

        private double CalculateRectangleArea(Func<double, double> function, int n)
        {
            double h = (X2 - X1) / (double)n;

            double area = 0;
            for (int i = 1; i <= n; i++)
            {
                area += function(X1 + i * h) * h;
            }
            return area;
        }
    }
}

