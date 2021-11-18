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
                }
                
                if (i % 13 == 0)
                {
                    int firstBIndex = output.FindIndex(w => w.StartsWith("B"));
                    if (firstBIndex == -1)
                    {
                        // If not found, insert at the start
                        firstBIndex = 0;
                    }
                    output.Insert(firstBIndex, "Fezz");
                }
                
                if (output.Count == 0)
                {
                    output.Add(i.ToString());
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