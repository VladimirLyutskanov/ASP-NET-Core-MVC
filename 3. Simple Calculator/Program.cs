using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] expression = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> output = new Stack<string>(expression.Reverse());

            while (output.Count > 1)
            {
                int operand1 = int.Parse(output.Pop());
                string opr = output.Pop();
                int operand2 = int.Parse(output.Pop());

                switch (opr)
                {
                    case "+":
                        output.Push((operand1 + operand2).ToString()); //output.Push($"{operand1 + operand2}")
                        break;
                    case "-":
                        output.Push((operand1 - operand2).ToString());
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(output.Pop());

        }
    }
}
