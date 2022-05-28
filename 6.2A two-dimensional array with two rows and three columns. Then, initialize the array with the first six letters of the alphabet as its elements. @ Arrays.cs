using System;

namespace TwoDimentionalApp
{
    class TwoDimentionalApp
    {
        static void Main()
        {
            string[,] input = new string[,]
            {
                {"A", "B", "C",},
                {"D", "E", "F",},
            };
            
            Console.WriteLine("The Element of the Arrays is:\n");
            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                string s1 = input[i, 0];
                string s2 = input[i, 1];
                string s3 = input[i, 2];
                Console.WriteLine("{0}, {1}, {2}", s1, s2, s3);
            }
        }
    }
}
