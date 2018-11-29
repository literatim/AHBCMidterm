using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Midterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> menu = Product.GetInventoryList();

            WriteLine("Welcome to the Oracle Java Shop! (written in C#)" + Environment.NewLine);

            WriteLine(Menu.PrintMenu(menu));

            List<Menu> menuSelections = new List<Menu>(Menu.BuildCustomerOrder(menu));

            var orderTotal = Menu.CalculateLineTotals(menuSelections);

            var grandTotal =  Calculator.CalculateGrandTotal(orderTotal);

            WriteLine(Environment.NewLine + $"Your total is: {grandTotal:C}. How would you like to pay?");
            WriteLine("1 - Cash");
            WriteLine("2 - Credit Card");
            WriteLine("3 - Check");
            Write(Environment.NewLine+ "Enter 1-3:");
            var paymentForm = int.Parse(ReadLine());

            switch (paymentForm)
            {
                case 1:
                        Payment.TakeCashPayment(grandTotal);
                    break;
                case 2:
                    Payment.TakeCreditPayment(grandTotal);
                    break;
                case 3:
                    Payment.TakeCheckPayment(grandTotal);
                    break;
                default:
                    WriteLine("Invalid selection.");
                    break;
            }

            //Display receipt


            //Save receipt in a list called OrderHistory



            ReadKey();

        }

    }
}
