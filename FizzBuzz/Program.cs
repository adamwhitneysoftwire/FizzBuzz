using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string Output = "";
                
                // Check multiple of 3
                if (i % 3 == 0)
                {
                    Output = Output + "Fizz";
                }
                
                // Check multiple of 5
                if (i % 5 == 0)
                {
                    Output = Output + "Buzz";
                }

                // If no output text, output the number
                if (Output.Length == 0)
                {
                    Output = i.ToString();
                }
                
                // Write output to the console
                Console.Out.WriteLine(Output);
            }
        }
    }
}