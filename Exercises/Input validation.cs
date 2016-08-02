using System;

namespace Input_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 to 10");
            int userInput = 0;
            userInput = int.Parse(Console.ReadLine());

            if (userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("Valid Input");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }
    }
}
