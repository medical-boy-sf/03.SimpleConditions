using System;

namespace _06.BonusScore
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;

             if (num > 1000)
            {
                bonus = 0.1 * num;
            }

            else if (num > 100)
            {
                bonus = 0.2 * num;
            }

            else if (num <= 100)
            {
                bonus += 5;
            }

             if (num % 2 == 0)
            {
                bonus += 1;
            }

             if (num % 10 == 5)
            {
                bonus += 2;
            }

            double total = num + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(total);
        }
    }
}
