using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
   
        public class Validation
        {
            public static void Int_Digits_check(string input, out int output)
            {
                if (!int.TryParse(input, out output))
                {
                    while (true)
                    {
                        Console.WriteLine("Invalid value (not a digit). Try again.");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out output))
                        {
                            output = int.Parse(input);
                            break;
                        }
                    }
                }
                else
                {
                    output = int.Parse(input);
                }
            }

            public static void Double_Digits_check(string input, out double output)
            {
                if (!double.TryParse(input, out output))
                {
                    while (true)
                    {
                        Console.WriteLine("Invalid value (not a digit). Try again.");
                        input = Console.ReadLine();
                        if (double.TryParse(input, out output))
                        {
                            output = double.Parse(input); //
                            break;
                        }
                    }
                }
                else
                {
                    output = double.Parse(input);
                }
            }

            public static void Decimal_Digits_check(string input, out decimal output)
            {
                if (!decimal.TryParse(input, out output))
                {
                    while (true)
                    {
                        Console.WriteLine("Invalid value (not a digit). Try again.");
                        input = Console.ReadLine();
                        if (decimal.TryParse(input, out output))
                        {
                            output = decimal.Parse(input); //
                            break;
                        }
                    }
                }
                else
                {
                    output = decimal.Parse(input);
                }
            }

            public static bool IsPrimeNumber(int input)
            {
                while (true)
                {
                    bool result = true;

                    if (input > 1)
                    {
                        for (int i = 2; i < input; i++)
                        {
                            if (input % i == 0)
                            {
                                result = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        result = false;
                    }

                    return result;
                }
            }

            public static void Prime_check(string input, out int prime)
            {
                while (true)
                {
                    Int_Digits_check(input, out prime);
                    if (IsPrimeNumber(prime) == true)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value (not prime). Try again.");
                        input = Console.ReadLine();

                    }
                }
            }

            public static void Borders(int botLine, int topLine, string input, out int line)
            {

                while (true)
                {
                    Int_Digits_check(input, out line);
                    if (line >= botLine && line <= topLine)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value (out of borders). Try again.");
                        input = Console.ReadLine();
                    }
                }
            }

            public static void Top_check(string input, int bot_line, out int top_line)
            {
                while (true)
                {
                    Borders(input, out top_line);
                    if (bot_line < top_line)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value (less than bottom line). Try again.");
                        input = Console.ReadLine();
                    }
                }
            }

            public static void LaptopCountCheck(string input, out int output, int counter)
            {

                while (true)
                {
                    Int_Digits_check(input, out output);
                    if (output + 1 > counter)
                    {
                        Console.WriteLine("Invalid value (out of available laptops amount). Try again.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
}



