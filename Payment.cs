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
            var input = Validator.ValidateCashPayment();
            while (input < total)
            {
                Console.WriteLine("Cash entered is less than amount due!");
                Console.Write("Enter amount tendered: ");
                input = Validator.ValidateCashPayment();
            }
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
            
            Console.Write("Enter last 4 of credit card number: ");
            creditCardNumber = Validator.ValidateCcNumber();

            Console.Write("Enter expiration date (MMYY): ");
            expDate = Validator.ValidateExpirationDate();

            Console.Write("Enter CVV (3 digits on back of card): ");
            cvv = Validator.ValidateCVVNumber();

            Console.WriteLine($"{total:C} will be charged to card number {creditCardNumber}.");

            creditCardList.Add(creditCardNumber);
            creditCardList.Add(expDate);
            creditCardList.Add(cvv);

            return creditCardList;


        }
        public static int TakeCheckPayment(double total)
        {
            Console.Write("Enter last 4 of checking account number: ");
            int checkNumber = Validator.ValidateCheckPayment();

            Console.WriteLine($"{total:C} will be charged to check number {checkNumber}.");

            return checkNumber;

        }
    }
}
