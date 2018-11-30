using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Menu
    {
        private string _item { get; set; }
        private double _multipliedPrice { get; set; }
        public double _multiplier { get; set; }

        public Menu(string Item, double MultipliedPrice, double Multiplier)
        {
            _item = Item;
            _multiplier = Multiplier;
            _multipliedPrice = MultipliedPrice;
        }

        public static List<Product> PrintMenu(List<Product> menu)
        {
            var number = 1;
            foreach (var Product in menu)
            {
                Console.WriteLine("|{0,3}| {1,10} | {2, 10} | {3,10} | {4,4} |", number, Product.Name, Product.Description, Product.Category, Product.Price);
                number++;
            }

            return menu;
        }

        public static List<Menu> BuildCustomerOrder(List<Product> menu)
        {
            List<Menu> menuSelections = new List<Menu>();
            var doAgain = true;
            while (doAgain)
            {
                Console.Write(Environment.NewLine + "Please choose your item(s) by number: ");
                var selection = Validator.ValidateMenuChoice();
                var foodItemPrice = menu[selection].Price;

                Console.Write(Environment.NewLine + "How many would you like? Please enter a whole number (ex. 1, 2, 3): ");
                var multiplier = Validator.ValidateMultiplierSelection();

                var multipliedFoodItemPrice = foodItemPrice * multiplier;

                menuSelections.Add(new Menu(menu[selection].Name, multipliedFoodItemPrice, multiplier));

                Console.Write(Environment.NewLine + "Would you like to add another item? (Yes/No): ");
                var repeat = Console.ReadLine();

                if (!repeat.StartsWith("y", StringComparison.OrdinalIgnoreCase))
                {
                    doAgain = false;
                }
            }

            return menuSelections;
        }

        public static double CalculateLineTotals(List<Menu> menuSelections)
        {
            double menuSum = 0;

            Console.WriteLine(Environment.NewLine + "Here is your order:");
            foreach (var Menu in menuSelections)
            {
                Console.WriteLine($"Line total for {Menu._item}(x{Menu._multiplier}): ${Menu._multipliedPrice}");

                menuSum += Menu._multipliedPrice;
            }

            return menuSum;
        }
    }
}
