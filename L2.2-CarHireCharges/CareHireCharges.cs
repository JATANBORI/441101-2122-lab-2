using System;

namespace L2._2_CarHireCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days was the car hired for?");
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine("How much fuel was in the car when it was hired?");
            int fuelWhenHired = int.Parse(Console.ReadLine());

            Console.WriteLine("How much fuel was in the car when it was returned?");
            int fuelWhenReturned = int.Parse(Console.ReadLine());

            int charge = days * 100 + fuelWhenHired - fuelWhenReturned * 2;

            Console.WriteLine("Hire charge is " + charge);
        }
    }
}
