using System;

namespace Person
{
    class Person
    {
        string full_name;

        public Person()
        {
            full_name = default;
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("fullname: " + person.full_name);
        }
    }
}
