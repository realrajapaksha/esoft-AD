using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Application
{
    internal class FindElement
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter Check Number :");
            int check = int.Parse(Console.ReadLine());

            bool iExist = false;
            int index = 0;

            foreach (var i in numbers.Select((value, i) => (value, i)))
            {
                if (i.value == check)
                {
                    iExist = true;
                    index = i.i;
                    break;
                }
            }

            if (iExist)
            {
                Console.WriteLine("Element Exist in index [{0}]", index);
            }
            else
            {
                Console.WriteLine("Element Not Exist in Array");
            }

            Console.ReadKey();
        }
    }
}
