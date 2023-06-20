using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square : S");
            Console.WriteLine("Triangle : T");
            String choice = Console.ReadLine();

            if (choice == "S")
            {
                Console.Write("Input Side : ");
                double side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area is : " + side * side);
                Console.ReadKey();

            }
            else if (choice == "T")
            {
                Console.Write("Input Base : ");
                double base1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input Height : ");
                double height = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Area is : " + (base1 * height) / 2.0);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong Input! Try again.");
            }
        }
    }
}
