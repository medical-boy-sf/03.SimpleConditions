﻿using System;

namespace _04.GreaterNumber
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }

            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
