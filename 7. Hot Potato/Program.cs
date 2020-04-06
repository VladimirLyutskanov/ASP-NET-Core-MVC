using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(Console.ReadLine().Split());
            int count = int.Parse(Console.ReadLine());

            while (names.Count>1)
            {
                for (int i = 0; i < count-1; i++)
                {
                    string player = names.Dequeue();
                    names.Enqueue(player);
                }

                Console.WriteLine($"Removed {names.Dequeue()}"); 
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
