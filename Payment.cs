using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Payment
    {
        public static List<string> TakeCashPayment(double total)
        {
            List<string> cashPayment = new List<string>();
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

            string cashReceipt = $"Cash tendered: {input:C} \nChange: {change:C}";
            cashPayment.Add(cashReceipt);

            return cashPayment;
        }

        public static List<string> TakeCreditPayment(double total)
        {
            int creditCardNumber, expDate, cvv;
            List<string> creditCardPayment = new List<string>();
            
            Console.Write("Enter last 4 of credit card number: ");
            creditCardNumber = Validator.ValidateLastFourNumbers();

            Console.Write("Enter expiration date (MMYY): ");
            expDate = Validator.ValidateExpirationDate();

            Console.Write("Enter CVV (3 digits on back of card): ");
            cvv = Validator.ValidateCVVNumber();

            Console.WriteLine($"{total:C} will be charged to card number (last 4) {creditCardNumber}.");

            string creditReceipt = $"CC #: {creditCardNumber}";
            creditCardPayment.Add(creditReceipt);

            return creditCardPayment;


        }
        public static List<string> TakeCheckPayment(double total)
        {
            List<string>checkPayment = new List<string>();

            Console.Write("Enter last 4 of checking account number: ");
            int checkNumber = Validator.ValidateLastFourNumbers();

            Console.WriteLine($"{total:C} will be charged to check number (last 4) {checkNumber}.");

            string checkReceipt = $"Check #: {checkNumber}";
            checkPayment.Add(checkReceipt);

            return checkPayment;

        }
    }
}
