using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Stack
    {
        int[] stk;
        int top;
        static int MAX = 20;
        public Stack()
        {
            top = -1;
            stk = new int[MAX];
        }

        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (top == MAX - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                stk[++top] = value;
            }
        }

        public int Pop()
        {
            int x = stk[top];
            top--;
            return x;
        }

        public void Display()
        {
            Console.WriteLine();
            Console.Write("Stack : ");
            for (int i = top; i >= 0; i--)
            {
                Console.Write(stk[i] + " ");
            }
        }

        public int DisplyTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            return stk[top];
        }

    }


    class StackTest
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            /*stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Display();
            Console.WriteLine();
            Console.WriteLine("Top item of the Stack : {0}", stack.DisplyTop());*/

            Console.WriteLine("---- Convert Decimal to Binary ----");
            Console.Write("Enter Number : ");
            int number = Convert.ToInt16(Console.ReadLine());

            bool isFinish = false;
            while (isFinish == false)
            {
                int i = number % 2;
                number = number / 2;

                if(number == 0)
                {
                    isFinish = true;
                }
                stack.Push(i);
            }

            stack.Display();

            Console.ReadKey();
        }
    }
}
