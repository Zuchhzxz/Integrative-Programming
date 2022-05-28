using System;
namespace ConsoleApp
{
    class ComputeRectangleArea
    {
        static void Main()
        {
            int length, width, area;
            length = 50;
            width = 8;
            area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadKey();
        }
    }
}
