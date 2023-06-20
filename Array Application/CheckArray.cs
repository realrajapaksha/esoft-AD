using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Application
{
    internal class CheckArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            if (numbers.Length >= 1)
            {
                if (numbers[0] == numbers[numbers.Length-1])
                {
                    Console.WriteLine("First Elemeny and Last are Equal");
                }
                else 
                { 
                    Console.WriteLine("First Elemeny and Last are Not Eqaul"); 
                }
            }

            Console.ReadKey();
        }
    }
}
