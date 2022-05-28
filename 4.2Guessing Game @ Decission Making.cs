using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class program
    {
        
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int num = random.Next(1, 100);
            int guess = 0;
            string welcome = "Guess the number from 1-100";
            Console.WriteLine(welcome);
            
            int i = 0;
            
            while(guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    
                    if (guess > num)
                    {
                        Console.WriteLine("Too High, Try again");
                    }
                    else
                    {
                        Console.WriteLine("Too Low, Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("!?");
                    i--;
                }
            }
            Console.WriteLine("Congrats, it took you " + i + "tries");
            Console.ReadLine();
        }
    }
}
