using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MethodOverloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total ={0}",MyMethod(10.5, 5.2));
            Console.WriteLine("Total ={0}", MyMethod(10, 5));

            Console.ReadKey();
        }

        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static double MyMethod(double x, double y)
        {
            return x + y;
        } 
    }
}
