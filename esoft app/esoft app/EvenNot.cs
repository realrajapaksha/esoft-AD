using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class EvenNot
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 1)
            {
                Console.Write("Number is Odd");
            }
            else
            {
                Console.Write("Number is Even");
            }
            Console.ReadLine();
        }
    }
}
