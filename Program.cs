using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLab
{
    class Program
    {
        public class TaxFormula
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double Area
            {
                get { return Length * Width; }
            }
            public double Perimeter
            {
                get { return ((Length * 2) + (Width * 2)); }
            }
            public TaxFormula() { }
            public TaxFormula(double l, double w)
            {
                Length = l;
                Width = w;
            }
        }
        static void Main(string[] args)
        {
            Console.Write(" Enter the Length of the land (in Yards): ");
            Double InputL = Convert.ToDouble(Console.ReadLine());



            Console.Write(" Enter the Width of the land (in Yards): ");
            Double InputW = Convert.ToDouble(Console.ReadLine());

            TaxFormula l = new TaxFormula(InputL, InputW);
            Decimal TotalCost = Convert.ToDecimal((l.Area * 5) + (l.Perimeter * .75));

        }
    }
}
