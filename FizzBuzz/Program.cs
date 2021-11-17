using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 200; i++)
            {
                string output = "";

                if (i % 11 == 0)
                {
                    if (i % 13 == 0)
                    {
                        output += "Fezz";
                    }
                    output += "Bong";
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        output += "Fizz";
                    }
                    
                    if (i % 13 == 0)
                    {
                        output += "Fezz";
                    }
                    
                    if (i % 5 == 0)
                    {
                        output += "Buzz";
                    }
                    
                    if (i % 7 == 0)
                    {
                        output += "Bang";
                    }

                    if (output.Length == 0)
                    {
                        output = i.ToString();
                    }
                }
                
                Console.Out.WriteLine(output);
            }
        }
    }
}