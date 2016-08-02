using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height of your image");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width of your image");
            var width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Your image is portrait");
            }
            else
            {
                Console.WriteLine("Your image is landscape");
            }
        }
    }
}
