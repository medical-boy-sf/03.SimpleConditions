using System;

namespace _20.SleepingCatTom
{
    class Program
    {
        static void Main()
        {
            int numberFreeDays = int.Parse(Console.ReadLine());
            int freeDays = numberFreeDays * 127;
            int workingDays = (365 - numberFreeDays) * 63;
            int totalMinsPlay = freeDays + workingDays;
            int difference = totalMinsPlay - 30000;
            int hours = difference / 60;
            int minutes = difference % 60;

            if (difference <= 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes less for play");
            }

            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }

        }
    }
}
