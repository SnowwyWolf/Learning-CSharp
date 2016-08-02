using System;


namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 20;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char) ('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
            //  Console.WriteLine((int)'a');
        }
    }
}