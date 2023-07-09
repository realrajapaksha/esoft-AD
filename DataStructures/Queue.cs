using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Queue
    {
        int front;
        int rear;
        int[] que;
        static int MAX = 5;
        public Queue()
        {
            front = 0;
            rear = -1;
            que = new int[MAX];
        }

        public bool isEmpty()
        {
            return (front == rear + 1);
        }

        public bool isFull()
        {
            return (rear == MAX - 1);
        }

        public void Enqueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                rear++;
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
                front++;

                return x;
            }
        }

        private int Count()
        {
            int x = 0;
            for (int i = front; i <= rear; i++)
            {
                x++;
            }
            return x;
        }

        public void Display()
        {
            Console.WriteLine();
            Console.Write("Queue Content : ");

            for (int i = front; i <= rear; i++)
            {
                Console.Write("{0} ", que[i]);
            }
        }
    }

    internal class QueueTest
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
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
