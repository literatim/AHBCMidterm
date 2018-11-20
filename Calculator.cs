using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Calculator
    {

        private static double _taxRatePercent = .06;

        //Console.Writeline("Input price of itme : ")

        double itemPrice = double.Parse(Console.ReadLine());
        double totalPrice = double.Parse(Console.ReadLine());

        public double CalculateTax(string inputItemPrice, string inputTaxRate, string inputTotalPrice)
        {

            itemPrice = double.Parse(inputItemPrice);
            _taxRatePercent = double.Parse(inputTaxRate) / 100;
            totalPrice = double.Parse(inputTotalPrice);
            return totalPrice;
        }

        public void CalclulateSubTotal()
        {
            itemPrice += (itemPrice * _taxRatePercent);
        }

        public void GetTotalPrice()
        {
            totalPrice = _taxRatePercent + itemPrice;
        }
        public void GetTotalMessage()
        {
            Console.WriteLine("The item price is {0:C} and the total price is {1:C} at the tax rate of {2:p0}", itemPrice, totalPrice, _taxRatePercent);
        }
    }
}
    

    
