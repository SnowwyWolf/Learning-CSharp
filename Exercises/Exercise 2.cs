using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
            
        }
    }
}
