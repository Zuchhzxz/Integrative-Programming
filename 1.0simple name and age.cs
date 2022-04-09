/*
Author: John Ezekiel 'Zuchh' Bote
*/

using System;
namespace ConsoleApp
{
    class GreetingProgram
    {
        static void Main (string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hi! Your name is " + name + " and your age is " + age);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
