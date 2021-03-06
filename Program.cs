﻿using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Midterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                List<Product> menu = Product.GetInventoryList(); 

                WriteLine("Welcome to the Oracle Java Shop! (written in C#)" + Environment.NewLine);

                string title = @"
                          {
                          {   }
                           }_{ __{
                        .-{   }   }-.
                       (   }     {   )
                       |`-.._____..-'|
                       |             ;--.
                       |            (__  \
                       |             | )  )
                       |             |/  /
                       |             /  /
                       |            (  /
                       \             y'
                        `-.._____..-'
                ";

                Console.WriteLine(title + Environment.NewLine);

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Menu.PrintMenu(menu);

                List<Menu> menuSelections = new List<Menu>(Menu.BuildCustomerOrder(menu));

                var orderTotal = Menu.CalculateLineTotals(menuSelections);

                var taxOwed = Calculator.CalculateSalesTax(orderTotal);

                var grandTotal =  Calculator.CalculateGrandTotal(orderTotal);

                WriteLine(Environment.NewLine + $"Your total is: {grandTotal:C}. How would you like to pay?");
                WriteLine("1 - Cash");
                WriteLine("2 - Credit Card");
                WriteLine("3 - Check");
                Write(Environment.NewLine+ "Enter 1-3: ");

                var paymentForm = Validator.ValidatePaymentChoice();

                var orderReceipt = new Receipt
                {
                    ItemsPurchased = menuSelections,
                    Taxes = taxOwed,
                    Subtotal = orderTotal,
                    GrandTotal = grandTotal
                };

                switch (paymentForm)
                {
                    case 1:
                        orderReceipt.PaymentDetails = Payment.TakeCashPayment(grandTotal);
                        break;
                    case 2:
                        orderReceipt.PaymentDetails = Payment.TakeCreditPayment(grandTotal);
                        break;
                    case 3:
                        orderReceipt.PaymentDetails = Payment.TakeCheckPayment(grandTotal);
                        break;
                    default:
                        WriteLine("Invalid selection.");
                        break;
                }

                Console.Clear();

                Console.WriteLine("YOUR RECEIPT");
                Console.WriteLine(DateTime.Now + Environment.NewLine);

                Console.WriteLine("ITEMS");
                foreach (var item in menuSelections)
                {
                    Console.WriteLine("{0} x{1} = {2:C}", item._item, item._multiplier, item._multipliedPrice);
                    
                }

                Console.WriteLine(Environment.NewLine + "TOTAL");
                Console.WriteLine($"Subtotal: {orderReceipt.Subtotal:C}");
                Console.WriteLine($"Tax (MI 6%): {orderReceipt.Taxes:C}");
                Console.WriteLine($"Total: {orderReceipt.GrandTotal:C}");

                Console.WriteLine(Environment.NewLine + $"PAYMENT");
                foreach (var payment in (IEnumerable) orderReceipt.PaymentDetails)
                {
                    Console.WriteLine(payment);

                }

                List<Receipt> orderHistoryList = new List<Receipt>();
                orderHistoryList.Add(orderReceipt);


                Console.Write(Environment.NewLine + "Would you like to place another order? (Y/N): ");

            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }

    }
}
