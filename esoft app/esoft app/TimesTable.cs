using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class TimesTable
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Interger : ");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Times " + number + " Table");
            Console.WriteLine();
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine(i + " * " + number + " = " + number * i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
