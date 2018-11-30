using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Calculator
    {         
            private const double salesTax = 0.06d;

            public static double CalculateGrandTotal(double orderTotal)
            {
                double taxTotal = CalculateSalesTax(orderTotal);

                double grandTotal = taxTotal + orderTotal;

                return grandTotal;
            }

            public static double CalculateSalesTax(double amount)
            {
                return (salesTax * amount);
            }
        }

    }