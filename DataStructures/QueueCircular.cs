using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class QueueCircular
    {
        int front;
        int rear;
        int size;
        int[] que;
        static int MAX = 5;
        public QueueCircular()
        {
            front = 0;
            rear = -1;
            size = 0;
            que = new int[MAX];
        }

        public bool isEmpty()
        {
            return (size == 0);
        }

        public bool isFull()
        {
            return (size == MAX);
        }

        public int Increment(int x)
        {
            if (++x == MAX)
                return 0;
            return x;
        }

        public void Enqueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                rear = Increment(rear);
                size++;
                que[rear] = value;
            }
        }

        public int Dequeue()
        {
            if (isEmpty())
            {
                return -1;
            }
            else
            {
                int x = que[front];
                front = Increment(front);
                size--;

                return x;
            }
        }

        private int Count()
        {
            return size;
        }

        public void Display()
        {
            Console.WriteLine();
            Console.Write("Queue Content : ");

            int i = front;

            while (i != rear)
            {
                Console.Write("{0} ", que[i]);
                i = Increment(i);
            }
            Console.Write("{0} ", que[i]);
        }
    }


    class QueueCircularTest
    {
        static void Main(string[] args)
        {
            QueueCircular queue = new QueueCircular();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            queue.Display();
            queue.Dequeue();
            queue.Display();
            queue.Enqueue(60);

            queue.Display();
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(70);
            queue.Display();
            queue.Enqueue(50);

            queue.Display();
            Console.ReadKey();
        }
    }
}
