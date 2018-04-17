using System;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main()
        {
            int personOne = int.Parse(Console.ReadLine());
            int personTwo = int.Parse(Console.ReadLine());
            int personThree = int.Parse(Console.ReadLine());

            int sum = personOne + personThree + personTwo;

            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");


        }
    }
}
