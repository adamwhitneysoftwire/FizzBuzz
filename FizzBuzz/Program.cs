using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 300; i++)
            {
                List<string> output = new List<string>();
                
                if (i % 3 == 0 & i % 11 > 0)
                {
                    output.Add("Fizz");
                }
                
                if (i % 13 == 0)
                {
                    output.Add("Fezz");
                }

                if (i % 11 == 0)
                {
                    output.Add("Bong");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        output.Add("Buzz");
                    }

                    if (i % 7 == 0)
                    {
                        output.Add("Bang");
                    }
                    
                    if (output.Count == 0)
                    {
                        output.Add(i.ToString());
                    }
                }

                if (i % 17 == 0)
                {
                    output.Reverse();
                }
                
                Console.Out.WriteLine(String.Join("", output));
            }
        }
    }
}