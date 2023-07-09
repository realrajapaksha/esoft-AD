using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{


    internal class StackChar
    {
        char[] stk;
        int top;
        static int MAX = 20;
        public StackChar()
        {
            top = -1;
            stk = new char[MAX];
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

        public void Push(char value)
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

        public char Pop()
        {
            char x = stk[top];
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
    }


    class StackTest2
    {
        static void Main(string[] args)
        {
            StackChar stack = new StackChar();

            Console.WriteLine("---- Reverse Given Name ----");
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            foreach (char i in name)
            {
                stack.Push(i);
            }

            stack.Display();

            Console.ReadKey();
        }
    }
}
