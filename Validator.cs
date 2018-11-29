using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Validator
    {
        public static int ValidateUserSelection()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Please enter a number: ");
            }

            return input;
        }

    }
}
