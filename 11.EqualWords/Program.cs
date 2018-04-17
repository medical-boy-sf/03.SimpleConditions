using System;

namespace _11.EqualWords
{
    class Program
    {
        static void Main()
        {
            string wordOne = Console.ReadLine().ToLower();
            string wordTwo = Console.ReadLine().ToLower();
            bool equalWords = wordOne == wordTwo;
            
            if (equalWords)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
