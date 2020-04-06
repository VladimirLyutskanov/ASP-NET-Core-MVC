using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> output = new Stack<int>(input);
            string command = string.Empty;
            

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string [] splitted = command.Split();
                string opr = splitted[0];

                switch (opr)
                {
                    case "add":
                        for (int i = 1; i < splitted.Length; i++)
                        {
                            output.Push(int.Parse (splitted[i])); //output.Push($"{operand1 + operand2}")                          
                        }
                        break;
                    case "remove":
                        int remove = int.Parse(splitted[1]);
                        if (remove>=output.Count)
                        {
                            continue;
                        }
                        for (int j = 0; j < remove; j++)
                        {
                            output.Pop();                       
                        }
                        break;
                    default:
                       break;
                }
            }
            int total = output.Sum();
            Console.WriteLine($"Sum: {total}");
        }
    }
}
