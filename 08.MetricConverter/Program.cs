using System;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main()
        {
            double val = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double m = 1;
            double mm = 1000;
            double cm = 100;
            double miles = 0.000621371192;
            double inches = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;
            double result = 0;




            if (input == "m")
            {
                switch (output)
                {
                    case "m":
                        result = val * m / m;
                        break;
                    case "mm":
                        result = val * mm / m;
                        break;
                    case "cm":
                        result = val * cm / m;
                        break;
                    case "mi":
                        result = val * miles / m;
                        break;
                    case "in":
                        result = val * inches / m;
                        break;
                    case "km":
                        result = val * km / m;
                        break;
                    case "ft":
                        result = val * ft / m;
                        break;
                    case "yd":
                        result = val * yd / m;
                        break;
                }
            }

            else if (input == "mm")
            {
                switch (output)
                {
                    case "mm":
                        result = val * mm / mm;
                        break;
                    case "m":
                        result = val * m / mm;
                        break;
                    case "cm":
                        result = val * cm / mm;
                        break;
                    case "mi":
                        result = val * miles / mm;
                        break;
                    case "in":
                        result = val * inches / mm;
                        break;
                    case "km":
                        result = val * km / mm;
                        break;
                    case "ft":
                        result = val * ft / mm;
                        break;
                    case "yd":
                        result = val * yd / mm;
                        break;
                }
            }

            else if (input == "cm")
            {
                switch (output)
                {
                    case "cm":
                        result = val * cm / cm;
                        break;
                    case "m":
                        result = val * m / cm;
                        break;
                    case "mm":
                        result = val * mm / cm;
                        break;
                    case "mi":
                        result = val * miles / cm;
                        break;
                    case "in":
                        result = val * inches / cm;
                        break;
                    case "km":
                        result = val * km / cm;
                        break;
                    case "ft":
                        result = val * ft / cm;
                        break;
                    case "yd":
                        result = val * yd / cm;
                        break;
                }
            }

            else if (input == "mi")
            {
                switch (output)
                {
                    case "mi":
                        result = val * miles / miles;
                        break;
                    case "m":
                        result = val * m / miles;
                        break;
                    case "mm":
                        result = val * mm / miles;
                        break;
                    case "cm":
                        result = val * cm / miles;
                        break;
                    case "in":
                        result = val * inches / miles;
                        break;
                    case "km":
                        result = val * km / miles;
                        break;
                    case "ft":
                        result = val * ft / miles;
                        break;
                    case "yd":
                        result = val * yd / miles;
                        break;
                }
            }

            else if (input == "in")
            {
                switch (output)
                {
                    case "in":
                        result = val * inches / inches;
                        break;
                    case "m":
                        result = val * m / inches;
                        break;
                    case "mm":
                        result = val * mm / inches;
                        break;
                    case "cm":
                        result = val * cm / inches;
                        break;
                    case "mi":
                        result = val * miles / inches;
                        break;
                    case "km":
                        result = val * km / inches;
                        break;
                    case "ft":
                        result = val * ft / inches;
                        break;
                    case "yd":
                        result = val * yd / inches;
                        break;
                }
            }

            else if (input == "km")
            {
                switch (output)
                {
                    case "km":
                        result = val * km / km;
                        break;
                    case "m":
                        result = val * m / km;
                        break;
                    case "mm":
                        result = val * mm / km;
                        break;
                    case "cm":
                        result = val * cm / km;
                        break;
                    case "mi":
                        result = val * miles / km;
                        break;
                    case "in":
                        result = val * inches / km;
                        break;
                    case "ft":
                        result = val * ft / km;
                        break;
                    case "yd":
                        result = val * yd / km;
                        break;
                }
            }

            else if (input == "ft")
            {
                switch (output)
                {
                    case "ft":
                        result = val * ft / ft;
                        break;
                    case "m":
                        result = val * m / ft;
                        break;
                    case "mm":
                        result = val * mm / ft;
                        break;
                    case "cm":
                        result = val * cm / ft;
                        break;
                    case "mi":
                        result = val * miles / ft;
                        break;
                    case "in":
                        result = val * inches / ft;
                        break;
                    case "km":
                        result = val * km / ft;
                        break;
                    case "yd":
                        result = val * yd / ft;
                        break;
                }
            }

            else if (input == "yd")
            {
                switch (output)
                {
                    case "m":
                        result = val * m / yd;
                        break;
                    case "mm":
                        result = val * mm / yd;
                        break;
                    case "cm":
                        result = val * cm / yd;
                        break;
                    case "mi":
                        result = val * miles / yd;
                        break;
                    case "in":
                        result = val * inches / yd;
                        break;
                    case "km":
                        result = val * km / yd;
                        break;
                    case "ft":
                        result = val * ft / yd;
                        break;
                    case "yd":
                        result = val * yd / yd;
                        break;
                }
            }

            Console.WriteLine($"{result:F8}");
        }
    }
}
