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
            
            Double income = Convert.ToDouble(args);
           Double taxRate;
            MyTaxBracket TaxBracket=new MyTaxBracket(income);
            switch (TaxBracket)                     
            {   
                case MyTaxBracket.lessthanTwenty:

                    TaxFormula taxR = new TaxFormula(income, taxRate);
                    Decimal TotalTaxes = Convert.ToDecimal((taxR.CalulateTaxes));

                    break;



                default:
                    Console.WriteLine("You broke it!!");    

            }

           
            

           // TaxFormula taxBracket = new TaxFormula
           

        }
    }
    enum MyTaxBracket
    {lessthanTwenty,overTwenty,overFifty,overSeventy}
        
    
}
