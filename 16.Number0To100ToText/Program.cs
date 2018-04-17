using System;

namespace _16.Number0To100ToText
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int ones = num % 10;
            int tens = (num / 10) % 10;
            int hundred = num / 100;
            string str = null;

            if (num >= 0 && num <= 100)
            {



                if (hundred == 1)
                {
                    str += "one hundred";
                }

                else
                {
                    switch (tens)
                    {
                        case 0:
                            switch (ones)
                            {
                                case 0:
                                    str += "zero"; break;
                                case 1:
                                    str += "one"; break;
                                case 2:
                                    str += "two"; break;
                                case 3:
                                    str += "three"; break;
                                case 4:
                                    str += "four"; break;
                                case 5:
                                    str += "five"; break;
                                case 6:
                                    str += "six"; break;
                                case 7:
                                    str += "seven"; break;
                                case 8:
                                    str += "eight"; break;
                                case 9:
                                    str += "nine"; break;
                            }
                            break;

                        case 1:
                            switch (ones)
                            {
                                case 0:
                                    str += "ten"; break;
                                case 1:
                                    str += "eleven"; break;
                                case 2:
                                    str += "twelve"; break;
                                case 3:
                                    str += "thirteen"; break;
                                case 4:
                                    str += "fourteen"; break;
                                case 5:
                                    str += "fifteen"; break;
                                case 6:
                                    str += "sixteen"; break;
                                case 7:
                                    str += "seventeen"; break;
                                case 8:
                                    str += "eighteen"; break;
                                case 9:
                                    str += "nineteen"; break;
                            }
                            break;

                        case 2:
                            str += "twenty";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 3:
                            str += "thirty";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 4:
                            str += "forty";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 5:
                            str += "fifty";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 6:
                            str += "sixty";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 7:
                            str += "seventy";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 8:
                            str += "eighty";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;

                        case 9:
                            str += "ninety";
                            switch (ones)
                            {
                                case 1:
                                    str += " one"; break;
                                case 2:
                                    str += " two"; break;
                                case 3:
                                    str += " three"; break;
                                case 4:
                                    str += " four"; break;
                                case 5:
                                    str += " five"; break;
                                case 6:
                                    str += " six"; break;
                                case 7:
                                    str += " seven"; break;
                                case 8:
                                    str += " eight"; break;
                                case 9:
                                    str += " nine"; break;
                            }
                            break;
                    }
                }

                Console.WriteLine(str);
            }

            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
