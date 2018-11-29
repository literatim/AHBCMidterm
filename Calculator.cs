using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Calculator

    {         
            // test comment
            private const double salesTax = 0.06d;
            //total without sales tax
            //public double CalculateTotal(List<Product> products)
            //{
            //    double sum = 0;
            //    for (int i = 0; i < products.Count; i++)
            //    {
            //        sum += products[i].Price;
            //    }


            //    return sum;
            //}
        //Console.Writeline("Input price of item : ")


            //passes price as a double which is the price of the item
            public static double CalculateGrandTotal(double orderTotal)
            {

                //double orderTotal = CalculateTotal(products);

                //takes product total and adds that to product sales tax

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

//=======
//    {

//        private static double _taxRatePercent = .06;

//        //Console.Writeline("Input price of itme : ")


//        public double CalculateTax(string inputItemPrice, string inputTaxRate, string inputTotalPrice)
//        {

//            itemPrice = double.Parse(inputItemPrice);
//            _taxRatePercent = double.Parse(inputTaxRate) / 100;
//            totalPrice = double.Parse(inputTotalPrice);
//            return totalPrice;
//        }

//        public void CalclulateSubTotal()
//        {
//            itemPrice += (itemPrice * _taxRatePercent);
//        }

//        public void GetTotalPrice()
//        {
//            totalPrice = _taxRatePercent + itemPrice;
//        }
//        public void GetTotalMessage()
//        {
//            Console.WriteLine("The item price is {0:C} and the total price is {1:C} at the tax rate of {2:p0}", itemPrice, totalPrice, _taxRatePercent);
//        }
//    }
//}
    

    