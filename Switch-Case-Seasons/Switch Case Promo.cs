using System;

namespace if_else_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotions");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's snowwing, the cold is here");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}