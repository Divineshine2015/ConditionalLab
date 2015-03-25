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
            public double Income { get; set; }
            public double TaxRate { get; set; }
            public double CalulateTaxes
            {
                get { return (TaxRate*Income); }
            }
           
            public TaxFormula() { }
            public TaxFormula(double income,double taxRate)
            {
                Income = income;
                TaxRate = taxRate;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");
            Console.WriteLine(args[0]);
            Double income = Convert.ToDouble(args[0]);
            Console.WriteLine("args converted to double:{0:c2} ",income);

           
           
            //MyTaxBracket TaxBracket= MyTaxBracket.lessThanTwenty;
            //switch (TaxBracket)                     
            //{   
            //    case MyTaxBracket.lessThanTwenty:
            //        Double taxRate = .05;
            //        TaxFormula taxR = new TaxFormula(income, taxRate);
            //        Decimal TotalTaxes = Convert.ToDecimal((taxR.CalulateTaxes));
            //        Console.WriteLine("Your Taxes on income of {0:c2} is {1:c2}", income, TotalTaxes);
            //        break;
            //    case MyTaxBracket.overTwenty:


            //        break;
            //    case MyTaxBracket.overFifty:
            
            //        break;
            //    case MyTaxBracket.overSeventy:

            //        break;
  
            //    default:
            //        Console.WriteLine("You broke it!!");
            //        break;

            //}

       
        }
    }
    //enum MyTaxBracket
    //{lessThanTwenty,overTwenty,overFifty,overSeventy}
        
    
}
