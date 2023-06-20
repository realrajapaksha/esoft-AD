using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SumIndividual
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            string number = Console.ReadLine();
            Console.WriteLine($"Total is: {SplitSum(number)}");
            Console.ReadKey();
        }

        static int SplitSum(String number)
        {
            int total = 0;
            for (int i = 0; i < number.Length; i++)
            {
                total = total + Convert.ToInt16(number[i].ToString());
            }
            return total;
        }
    }
}
