using System;

namespace _19.TubesInAPool
{
    class Program
    {
        static void Main()
        {
            int volumePool = int.Parse(Console.ReadLine());
            int flowRateFirstTube = int.Parse(Console.ReadLine());
            int flowRateSecondTube = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());

            double volumeFirstTube = flowRateFirstTube * hoursMissing;
            double volumeSecondTube = flowRateSecondTube * hoursMissing;
            double howFullPool = volumeFirstTube + volumeSecondTube;
            int howFullPoolPer = (int)(howFullPool / volumePool * 100);
            int volumeFirstTubePer = (int)(volumeFirstTube / howFullPool * 100);
            int volumeSecondTubePer = (int)(volumeSecondTube / howFullPool * 100);



            if (volumePool >= howFullPool)
            {
                Console.WriteLine($"The pool is {howFullPoolPer}% full. Pipe 1: {volumeFirstTubePer}%. Pipe 2: {volumeSecondTubePer}%.");
            }

            else
            {
                Console.WriteLine($"For {hoursMissing} hours the pool overflows with {Math.Abs(volumePool - howFullPool):F1} liters.");
            }
        }
    }
}
