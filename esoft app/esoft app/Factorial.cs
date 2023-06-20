using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt16(Console.ReadLine());

            int fact = 1;
            for (int i = number; i >= 1; i--)
            {
                fact = fact * i ;
            }
            Console.WriteLine(fact);

            Console.ReadLine();
        }
    }
}
