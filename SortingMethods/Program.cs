using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 93, 50, 20, 80, 10, 44, 65, 15, 73 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ,");
            }
            Console.WriteLine();
            InsertionSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ,");
            }
            Console.ReadKey();

        }

        private static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        private static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int index = i - 1;
                while (index >= 0 && current < arr[index])
                {
                    arr[index + 1] = arr[index];
                    index = index - 1;
                }

                arr[index+1] = current;
            }
        }
    }
}
