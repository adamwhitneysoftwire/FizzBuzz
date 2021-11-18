using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Enter maximum number to output:");
            int max = Convert.ToInt32(Console.In.ReadLine());
            
            Console.Out.WriteLine("Enter rules to follow (e.g. 3, 5, 17) separated by commas:");
            string[] rules = Console.In.ReadLine().Split(",");
            int[] rulesInt = Array.ConvertAll(rules, s => Convert.ToInt32(s));
            bool fizzEnabled = rulesInt.Contains(3);
            bool buzzEnabled = rulesInt.Contains(5);
            bool bangEnabled = rulesInt.Contains(7);
            bool bongEnabled = rulesInt.Contains(11);
            bool fezzEnabled = rulesInt.Contains(13);
            bool reverseEnabled = rulesInt.Contains(17);
            
            for (int i = 1; i <= max; i++)
            {
                List<string> output = new List<string>();
                
                if (fizzEnabled & i % 3 == 0 & (!bongEnabled | i % 11 > 0))
                {
                    output.Add("Fizz");
                }

                if (bongEnabled & i % 11 == 0)
                {
                    output.Add("Bong");
                }
                else
                {
                    if (buzzEnabled & i % 5 == 0)
                    {
                        output.Add("Buzz");
                    }

                    if (bangEnabled & i % 7 == 0)
                    {
                        output.Add("Bang");
                    }
                }
                
                if (fezzEnabled & i % 13 == 0)
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

                if (reverseEnabled & i % 17 == 0)
                {
                    output.Reverse();
                }
                
                Console.Out.WriteLine(String.Join("", output));
            }
        }
    }
}