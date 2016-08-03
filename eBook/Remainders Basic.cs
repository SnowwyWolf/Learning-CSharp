using System;

namespace Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number to find the remainder: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number to find the remainder of the two: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int quotient = a/b;
            int remainder = a%b;
            Console.WriteLine(a + "/" +b + " is " + quotient + " remainder " + remainder);
            int same = b*quotient + remainder;
            Console.WriteLine(same);

        }
    }
}
