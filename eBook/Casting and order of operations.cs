using System;

namespace Casting_and_order_of_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0 + 1 + 1.0f; // 1.0 is a double + 1 + 1.0f = 3 stored as a double.
            int x = (int) (7 + 3.0/4.0*2); // 0.75 * 2 = 1.5 + 7 = 8.5 then casted to int giving the result of 8 (Data loss).
            Console.WriteLine(a + "and" + x); // Results as expected a is type double with the value of 3, x is type int with the value of 8.
            Console.WriteLine((1+1)/2*3); // 1 + 1 = 2 / 2 = 1 * 3 = 3, since we use OOP (Order of operations).

        }
    }
}
