using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);*/

            /*Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());*/
            /*queue.Display();

            queue.Dequeue();

            queue.Enqueue(8);
            queue.Display();
            queue.Dequeue();
            queue.Enqueue(9);

            queue.Display();*/


            /*Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Display();

            stack.Pop();
            stack.Pop();

            stack.Display();*/

            /*Console.WriteLine("Print Reverse Name");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            NameStack nameStack = new NameStack();

            for (int i = 0; i < name.Length; i++)
            {
                nameStack.Push(name[i]);
            }

            nameStack.Display();*/

            Console.WriteLine("Symbol Checker");
            Console.Write("Write Any code: ");

            string code = Console.ReadLine();
            NameStack codeStack = new NameStack();

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '{' || code[i] == '(' || code[i] == '[')
                {
                    codeStack.Push(code[i]);
                }
                else if (code[i] == '}' || code[i] == ')' || code[i] == ']')
                {
                    char sy = codeStack.Pop();
                    if (code[i] == '}')
                    {
                        if (sy != '{')
                        {
                            Console.WriteLine("Error at " + i + " ^" + code[i]);
                        }
                    }

                    if (code[i] == ')')
                    {
                        if (sy != '(')
                        {
                            Console.WriteLine("Error at " + i + " ^" + code[i]);
                        }
                    }

                    if (code[i] == ']')
                    {
                        if (sy != '[')
                        {
                            Console.WriteLine("Error at " + i + " ^" + code[i]);
                        }
                    }


                }
            }


            Console.ReadKey();
        }
    }
}
