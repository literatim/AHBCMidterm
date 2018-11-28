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

            WriteLine("Welcome to the Oracle Java Shop! (written in C#)");

        }
        
    }
}
