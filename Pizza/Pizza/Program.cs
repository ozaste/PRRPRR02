using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Enter name:");

            string Name = Console.ReadLine();

            Console.WriteLine("Your name is: " + Name);

            Console.WriteLine("Are you alive " + Name + "?");

            string alive = Console.ReadLine();

            Console.WriteLine("Alive: " + alive);

        }
    }
}
