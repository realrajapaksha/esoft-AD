using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array_Application
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter Number Index[{0}] : ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            foreach (var i in numbers.Select((value, i) => (value, i)))
            {
                Console.WriteLine("Index[{0}] = {1}", i.i, i.value);

            }

            Console.ReadKey();

        }
    }
}
