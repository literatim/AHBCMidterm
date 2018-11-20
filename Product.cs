using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
       

        public Product(string _name, string _category, string _description, double _price)
        {
            Name = _name;
            Category = _category;
            Description = _description;
            Price = _price;
        }


        public static List<Product> GetInventoryList()
        {
            string line;
            int index = 1;
            List<Product> menu = new List<Product>();

            using (StreamReader file =
                new StreamReader(@"C:\dev\GrandCircus\Midterm2\inventory.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] elements = line.Split(',');
                    menu.Add(new Product(elements[0], elements[1], elements[2], double.Parse(elements[3])));
                    index++;
                }
                //Console.WriteLine(file.ReadToEnd());
            }

            return menu;
        }
    }
}
