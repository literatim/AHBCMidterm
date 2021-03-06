﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Validator
    {
        public static uint ValidateMultiplierSelection()
        {
            uint input;
            while (!uint.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter a number: ");
            }

            return input;
        }

        public static int ValidateMenuChoice()
        {
            int input = Convert.ToInt16(ValidateMultiplierSelection());

            while (!Enumerable.Range(1, 12).Contains(input))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Please enter a number 1-12: ");
                input = Convert.ToInt16(ValidateMultiplierSelection());
            }

            return input - 1;

        }

        public static int ValidatePaymentChoice()
        {
            int input = Convert.ToInt16(ValidateMultiplierSelection());

            while (!Enumerable.Range(1, 3).Contains(input))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Please enter a number 1-3: ");
                input = Convert.ToInt16(ValidateMultiplierSelection());
            }

            return input;
        }

        public static double ValidateCashPayment()
        {
            double input;

            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid cash value!");
                Console.Write("Please enter a number: ");
            }

            if (input < 0)
            {
                input *= -1;
            }

            return input;
        }

        public static int ValidateLastFourNumbers()
        {
            int input = Convert.ToInt16(ValidateMultiplierSelection());

            while (input.ToString().Length != 4)
            {
                Console.WriteLine("Entry must be 4 digits!");
                Console.Write("Please enter last 4 digits: ");
                input = Convert.ToInt16(ValidateMultiplierSelection());
            }

            return input;
        }

        public static int ValidateExpirationDate()
        {
            int input = Convert.ToInt16(ValidateMultiplierSelection());


            while (input.ToString().Length != 4)
            {
                Console.WriteLine("Entry must be 4 digits!");
                Console.Write("Please enter expiration date (MMYY): ");
                input = Convert.ToInt16(ValidateMultiplierSelection());
            }

            return input;
        }

        public static int ValidateCVVNumber()
        {
            int input = Convert.ToInt16(ValidateMultiplierSelection());

            while (input.ToString().Length != 3)
            {
                Console.WriteLine("Invalid CVV number!");
                Console.Write("Enter CVV number (3 digits on back of card): ");
                input = Convert.ToInt16(ValidateMultiplierSelection());
            }

            return input;
        }
    }
}
