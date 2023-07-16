using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Day_2
{
    internal class Stack
    {
        Node top;

        public Stack()
        {
            top = null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(int x)
        {
            Node node = new Node(x, top);
            top = node;
        }

        public int Pop()
        {
            int x = -1;

            if (IsEmpty())
            {
                Console.WriteLine("Empty Stack");
                return x;
            }
            else
            {
                x = top.data;
                top = top.next;
            }
            return x;
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
