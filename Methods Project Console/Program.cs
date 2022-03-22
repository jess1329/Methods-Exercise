using System;

namespace Methods_Project_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
           //                                       Exercise 1

          //Name: Michael
         //Favorite Color: Blue
        //Favorite Animal: Walrus
       //Favorite Band: The Beatles

                Console.WriteLine("What is your first name?");
                var userName = Console.ReadLine();

                Console.WriteLine($" Hi, {userName}. What is your favorite color?");
                var color = Console.ReadLine();

                Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
                var animal = Console.ReadLine();

                Console.WriteLine($" Great! Now, what is your favorite band?");
                var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}! Here is your profile");

            Console.WriteLine($"Name: { userName}");
            Console.WriteLine($"Favorite color: { color}");
            Console.WriteLine($"Favorite animal: { animal}");
            Console.WriteLine($"Favorite band: { band}");
        }
    }
}
