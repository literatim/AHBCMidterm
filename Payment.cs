using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Payment
    {
        public static List<double> TakeCashPayment(double total)
        {
            List<double> cashPayment = new List<double>();
            Console.Write("Enter amount tendered: ");
            double input = Convert.ToDouble(Console.ReadLine());
            double change = input - total;

            Console.Write($"Cash tendered: {input:C}. Change: {change:C}");

            cashPayment.Add(input);
            cashPayment.Add(change);

            return cashPayment;
        }

        public static List<int> TakeCreditPayment(double total)
        {
            int creditCardNumber, expDate, cvv;
            List<int> creditCardList = new List<int>();
            
            Console.Write("Enter credit card number (16 digits): ");
            creditCardNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter expiration date (MMYY): ");
            expDate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter CVV (3 digits on back): ");
            cvv = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{total:C} will be charged to card number {creditCardNumber}.");

            creditCardList.Add(creditCardNumber);
            creditCardList.Add(expDate);
            creditCardList.Add(cvv);

            return creditCardList;


        }
        public static int TakeCheckPayment(double total)
        {
            Console.Write("Enter a checking account number: ");
            int checkNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{total:C} will be charged to check number {checkNumber}.");

            return checkNumber;

        }
    }
}
