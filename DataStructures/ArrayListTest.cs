using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class ArrayListTest
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding Some numbers");
            al.Add(56);
            al.Add(91);
            al.Add(45);
            al.Add(73);
            al.Add(15);
            al.Add(25);
            al.Add(6);

            Console.WriteLine("capacity{0}", al.Capacity);
            Console.WriteLine("count:{0}", al.Count);

            Console.Write("Content:");

            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Index of {0} is {1}", 73, al.IndexOf(73));
            al.Remove(45);
            Console.Write("content after deletion");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }


            Console.ReadKey();

        }
    }
}
