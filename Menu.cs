using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Menu
    {
        public static void PrintMenu(List<Product> menu)
        {
            var number = 1;
            foreach (var Product in menu)
            {
                Console.WriteLine($"{number}. {Product.Name} /n{Product.Category} /n{Product.Description} /n{Product.Price}.");
                number++;
            }
        }
    }
}
