using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esoft_app
{
    internal class CheckTwo
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Number 1 : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Number 2 : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1== 30 || number2 ==30)
            //{
            //    Console.Write("true");
            //}
            //else if(number1+number2 == 30)
            //{
            //    Console.Write("true");
            //}
            //else
            //{
            //    Console.Write("false");
            //}


            Console.Write("Enter Number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 3 : ");
            int number3 = Convert.ToInt32(Console.ReadLine());


            if (number1 < number2)
            {
                if (number2 < number3)
                {
                    Console.Write("Number 3 large");
                }
                else
                {
                    Console.Write("Number 2 large");
                }
            }
            else if (number1 < number3)
            {
                Console.Write("Number 3 large");
            }
            else
            {
                Console.Write("Number 1 large");
            }


            Console.ReadLine();
        }
    }
}
