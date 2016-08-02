using System;


namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speedlimit of the area: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit) 
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit)/kmPerDemeritPoint;
                if (demeritPoints > 12)
                
                    Console.WriteLine("License Suspended");
                
                else
                
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                
            }
        
        }
    }
}
