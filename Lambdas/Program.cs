using System;
using Lambdas;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"add: {add(1, 2)}");

            int x = 10;
            Func<int, int> capture = a => a + x;
            Console.WriteLine($"capture: {capture(1)}");

            Value v = new Value(10);
            Action mutateValue = () => v.inner += 1;
            mutateValue();
            mutateValue();

            Console.WriteLine($"value: {v.inner}");

            // Oh no, multiple lambdas have mutable access!
            Action mutateValue2 = () => v.inner += 1;
            mutateValue2();
            mutateValue2();

            Console.WriteLine($"value: {v.inner}");
        }
    }
}
