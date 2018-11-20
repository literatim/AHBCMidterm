using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Menu
    {
        public void PrintMenu(List<Product> menu)
        {
            var number = 1;
            foreach (var Product in menu)
            {
                Console.WriteLine($"{number}. {Product.Name} /n{Product.Category} /n{Product.Description} /n{Product.Price}.");
                number++;
            }
        }

        public double BuildCustomerOrder(List<Product> menu)
        {
            List<double> menuSelections = new List<double>();
            var doAgain = true;
            Console.Write("Please choose your item(s) by number: ");
            while (doAgain)
            {
                var selection = Console.ReadLine();
                var foodItemPrice = menu[selection].Price;

                Console.Write("How many would you like? Please enter a whole number (ex. 1, 2, 3): ");
                var multiplier = Console.ReadLine();

                var multipliedFoodItemPrice = foodItemPrice * multiplier;
                menuSelections.Add(multipliedFoodItemPrice);

                Console.WriteLine($"The line total for this selection: ${item}");

                Console.Write("Would you like to add another item? Yes or No: ");
                var repeat = Console.ReadLine();

                if (repeat.StartsWith("y", StringComparison.OrdinalIgnoreCase))
                {
                    doAgain = true;
                }

                else
                {
                    doAgain = false;
                }
            }

            Console.WriteLine("Here is your total for each selection: ");
            foreach (var item in menuSelections)
            {
                Console.WriteLine($"Line total for this selection: ${item}");
            }

            double menuSum = menuSelections.Sum;
            return menuSum;
        }
    }
}
