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
            //total without sales tax
            public double CalculateTotal(List<Product> products)
            {
                double sum = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    sum += products[i].Price;
                }

                return sum;
            }

            //passes price as a double which is the price of the item
            public double CalculateGrandTotal(List<Product> products)
            {

                double productTotal = CalculateTotal(products);

                //takes product total and adds that to product sales tax
                return productTotal + CalculateSalesTax(productTotal);
            }

            public double CalculateSalesTax(double amount)
            {
                return (salesTax * amount);
            }
        }

    }

