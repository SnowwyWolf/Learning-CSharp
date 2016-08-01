using System;

namespace Operators_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            Console.WriteLine(a > b); // Gives a result of either true or false.

            var c = 3;
            Console.WriteLine(c > b && c > a); // If both C is greater than a and b the result is true
        }
    }
}
