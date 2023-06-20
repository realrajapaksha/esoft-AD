using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CountSpaces
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string word = Console.ReadLine();
            Console.WriteLine($"Space Count is {SplitWord(word)}");

            Console.ReadKey();
        }

        static int SplitWord(string word)
        {
            int spaceCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }
    }
}
