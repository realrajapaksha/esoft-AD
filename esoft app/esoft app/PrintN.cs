using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class PrintN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N Number");
            int number = Convert.ToInt16( Console.ReadLine());

            int i = 1;
            while (i <= number)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
        }
}
