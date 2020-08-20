using System;

namespace KiloToMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter kilometers:");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double miles = kilometers / 1.609;
            Console.WriteLine(miles + " Miles");
        }
    }
}
