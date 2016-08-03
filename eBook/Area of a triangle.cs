using System;

namespace Area_of_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the base of the triangle: ");
            float _base = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the height of the triangle ");
            float _height = Convert.ToSingle(Console.ReadLine());
            float _area = _base*_height/2;
            Console.WriteLine("The area of the Triangle is " + _area);


        }
    }
}
