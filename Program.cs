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

            //Send order total to Calculator.CalculateGrandTotal method
            //Display order total and prompt for payment
            //Ask user to select form of payment
            //Call appropriate payment method
            //Display receipt
            //Save receipt in a list called OrderHistory



            ReadKey();

        }

    }
}
