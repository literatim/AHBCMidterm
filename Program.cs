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
<<<<<<< HEAD
            Console.WriteLine("Welcome to the Oracle Java Shop! (written in C#)");
=======
            List<Product> menu = Product.GetInventoryList();

            WriteLine("Welcome to the Oracle Java Shop! (written in C#)");


        }
        public static int GetUserInput()
        {
            int input;
            while (!int.TryParse(ReadLine(), out input))
            {
                WriteLine("Please enter a valid numerical value!");
                Write("Enter menu number: ");
            }

            return input;
>>>>>>> 641805a5b431cb4f6ec42e98da7038274b08e4ef
        }
    }
}
