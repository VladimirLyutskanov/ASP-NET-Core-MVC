using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = string.Empty;
            int counter = 0;

            while ((command=Console.ReadLine())!="end")
            {
                if (command=="green")
                {
                    if (cars.Count<count)
                    {
                        int totake = cars.Count;

                        for (int i = 0; i <totake; i++)
                        {                           
                            Console.WriteLine($"{cars.Dequeue()} passed!");                         
                        }

                        Console.WriteLine($"{count *counter + totake} cars passed the crossroads.");
                        return;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                    counter++;
                }
                else
                {
                    cars.Enqueue(command);
                }

                          
            }
            Console.WriteLine($"{count*counter} cars passed the crossroads.");
        }
    }
}
