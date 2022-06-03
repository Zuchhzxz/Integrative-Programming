using System;

namespace CircleDiameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Diameter of the Circle is: " + getCircleDiameter(10));
        }

        public static double getCircleDiameter(double radius)
        {
            double circleDiameter = radius * 2;
            return circleDiameter;
        }
    }
}
