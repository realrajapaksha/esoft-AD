using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    internal class NameListSort
    {
        static void Main(string[] args)
        {
            string[] nameArr = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name " + i + ": ");
                nameArr[i] = Console.ReadLine();
            }

            SelectionSort(nameArr);
            foreach (string name in nameArr)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();

            int exit = 1;
            while (exit == 1)
            {
                Console.Write("Search Name : ");
                string inputName = Console.ReadLine();
                int index = SearchList(nameArr, inputName);
                if (index == -1)
                {
                    Console.WriteLine("No Name found.");
                }
                else
                {
                    Console.WriteLine("Name found at index " + index + ".");
                }

                Console.Write("To continue press 1 or exit press 0 : ");
                exit = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        private static void SelectionSort(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min].CompareTo(arr[j]) > 0)
                    {
                        min = j;
                    }
                }
                string temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        private static int SearchList(string[] arr, string name)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
