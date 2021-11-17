using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";
                
                // Check multiple of 3
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                
                // Check multiple of 5
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                // If no output text, output the number
                if (output.Length == 0)
                {
                    output = i.ToString();
                }
                
                // Write output to the console
                Console.Out.WriteLine(output);
            }
        }
    }
}