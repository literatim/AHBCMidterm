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
            List<Product> menuChoices = new List<Product>();
            using (StreamReader sr = new StreamReader(@"C:/dev/GrandCircus/Midterm2/inventory.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = str.Split(',');
                    Product Menu = new Product(strArray[0], strArray[1], strArray[2], double.Parse(strArray[3]));

                    menuChoices.Add(Menu);

                }
            }

            return menuChoices;
        }
    }
}
