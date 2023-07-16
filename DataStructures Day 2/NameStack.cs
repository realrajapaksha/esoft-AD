using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures_Day_2
{
    internal class NameStack
    {
        NameNode top;

        public NameStack()
        {
            top = null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(char x)
        {
            NameNode node = new NameNode(x, top);
            top = node;
        }

        public char Pop()
        {
            char x = 'Z';

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
            NameNode temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
