using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Application
{
    internal class AddnSort
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 3, 5, 7, 9 };
            int[] arr2 = new int[5] { 2, 4, 6, 8, 10 };

            int[] arr3 = new int[10];
            int index = 0;

            // first method
            //for (int i = 0; i < 5; i++)
            //{
            //    arr3[i] = arr1[i];
            //}


            //for (int i = 5; i < 10; i++)
            //{
            //    arr3[i] = arr2[index];
            //    index++;
            //}

            //Array.Sort(arr3);


            // second method
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[index++] = arr1[i];
                arr3[index++] = arr2[i];
            }

            Console.Write("{");
            foreach (int i in arr3)
            {
                Console.Write("{0},", i);
            }
            Console.Write("}");
            Console.ReadKey();




        }
    }
}
