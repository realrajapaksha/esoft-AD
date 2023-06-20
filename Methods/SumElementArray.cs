using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SumElementArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int total = 0;
            foreach(int element in array)
            {
                total = Sum(total, element);
            }
            Console.WriteLine($"Total Sum of Element of Array : {total}");

            Console.ReadKey();
        }

        static int Sum(int total, int elemet)
        {
            return total + elemet;
        }
    }
}
