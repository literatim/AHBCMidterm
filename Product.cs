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



        public static void GetInventoryList()
        {
            using (StreamReader file =
                new StreamReader(@"C:\dev\GrandCircus\Midterm2\inventory.txt"))
            {
                //Console.WriteLine(file.ReadToEnd());
            }
        }
    }
}
