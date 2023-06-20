using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CheckPrime
    {
        static void Main(string[] args)
        {
            int number  = Convert.ToInt16(Console.ReadLine());
            int res = CheckPrimeNumber(number);
            if(res == 0)
            {
                Console.WriteLine($"{number} is not prime number");
            }
            else
            {
                Console.WriteLine($"{number} is prime number");
            }
            Console.ReadKey();
        }

        static int CheckPrimeNumber(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
}
