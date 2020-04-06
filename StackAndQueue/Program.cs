using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackDemo
{
    class Stack
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> output = new Stack<char>();

            Console.WriteLine(string.Join("", output));
            foreach (var ch in input)
            {
                output.Push(ch);
            }
            
            while (output.Count > 0)
            {
                Console.Write(output.Pop());
            }
            Console.WriteLine();
            
        }
    }
}
