using System;

namespace computeAverageApp
{
    class ComputeAverageApp
    {
        static void Main(string[] args)
        {
            double average = 0;
            Console.WriteLine("Enter 5 grades seperate  by new line: ");
            Console.ReadLine();
            
            for (int i=1; i<5; i++)
            {
                Console.WriteLine("");
                double num = Convert.ToDouble(Console.ReadLine());
                average + = num;
            }
            
            double fa = average /5;
            int fc = Convert.ToInt32(fa);
            Console.WriteLine("the average is " + fa + "and round off to " + fc);
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
