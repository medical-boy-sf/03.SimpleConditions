using System;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }

            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(r, 2);
            }

            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;
            }

            else if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
