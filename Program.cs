using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 23.14f;
            char character = 'A';
            string firstName = "Art";
            bool isWorking = false;


            Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            Console.Write("What is your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10 " + (rand.Next(1,11)));
        }
    }
}
