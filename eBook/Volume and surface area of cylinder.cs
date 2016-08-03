using System;

namespace Volume_of_a_cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the height of the Cylinder: ");
            var height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type in the radius of the base: ");
            var radius = Convert.ToDouble(Console.ReadLine());
            var Pi = 3.1415926;
            var volume = Pi*(radius*radius)*height;  // Calculates the volume of a cylinder.
            var surfaceArea = (Pi * 2)*radius*(radius + height); // Calculates the surface area of a cylinder.
            Console.WriteLine("The volume of the Cylinder is: " + volume + " Cubic units");
            Console.WriteLine("The surface area of the Cylinder is: " + surfaceArea + " Squared units");
            Console.ReadKey();
        }
    }
}
