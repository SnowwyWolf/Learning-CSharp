using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);
            try
            {
                var number = "1234";
                int a = Convert.ToByte(number);
                Console.WriteLine(a);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
                
            }
            try
            {
                string str = "true";
                bool f = Convert.ToBoolean(str);
                Console.WriteLine(f);
            }
            catch
            {
            }
        }
    }
}
