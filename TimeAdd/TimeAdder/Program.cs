using System;
using TimeAddLibrary;

namespace TimeAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan total = 3.Mins() + 157.Secs() + 2.Hours();

            Console.WriteLine($"Total time: {total.HumanReadable()}");
        }
    }
}
