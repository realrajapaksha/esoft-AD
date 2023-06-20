using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class Circle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (22.0 / 7.0) * radius;
            Console.WriteLine("Perimeter is " +Math.Round(perimeter, 2) );


            double area = ((22.0 / 7.0) * (radius*radius)) ;
            Console.WriteLine("Area is "+Math.Round(area, 2));

            Console.ReadLine();
        }
    }
}
