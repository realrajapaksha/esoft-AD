using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SwapNumber
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt16(Console.ReadLine());
            int number2 = Convert.ToInt16(Console.ReadLine());

            Swap(number1, number2);
            Console.ReadKey();
        }

        static void Swap(int x, int y)
        {
            Console.WriteLine($"Before x is {x} y is {y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After x is {x} y is {y}");
        }
    }
}
