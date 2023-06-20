using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Methods
{
    internal class SampleMethod
    {
        static void Main(string[] args)
        {
            //MyMethod("Kamal", 18);
            //MyMethod("Mala", 20);

            /// call and print 
            //Console.WriteLine(MyMethod(10, 5));

            /// call and asign return result to variable
            //int res = MyMethod(10, 5);
            //Console.WriteLine(res);

            // Named Arguments
            MyMethod (child2: "Kamal",child1: "Amal", child3: "Nimal");


            Console.ReadKey();
        }

        /// method without return
        //static void MyMethod(string name, int age)
        //{
        //    Console.WriteLine($"Name {name} is {age} years");
        //}

        /// method with return
        //static int MyMethod(int x, int y)
        //{
        //    return x + y;
        //}

        /// method with named Arguments
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine($" 1:{child1} 2:{child2} 3:{child3}");
        }
    }
}
