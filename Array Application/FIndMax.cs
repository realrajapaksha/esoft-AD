using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Application
{
    internal class FIndMax
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 10, 5, 6, 7, 8 };

            //Console.WriteLine("Maximum Value is : " + numbers.Max());

            int max = numbers[0];

            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
