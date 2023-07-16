using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Day_2
{
    internal class Queue
    {
        Node front;
        Node rear;
        int size;

        public Queue()
        {
            this.front = null;
            this.rear = null;
            this.size = 0;
        }

        public bool IsEmpty()
        {
            if(size == 0)
            {
                return true;
            }
            return false;
        }

        public void Enqueue(int x)
        {
            Node node = new Node(x);
            if(IsEmpty() )
            {
                front = rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
            }

            size++;
        }


        public int Dequeue()
        {
            int x = -1;
            if(IsEmpty())
            {
                Console.WriteLine("Empty Queue");
            }
            else
            {
                x = front.data;
                front = front.next;
                size--;
            }
            return x;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Queue");
            }
            else
            {
                Node temp = front;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
