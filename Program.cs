//===========================================================
// Title:         Deliverable 2 C# 
//  Author :      Earle Fox>
//  Date :        12/02/2022
//  Description : All you can eat buffet
//       
//===========================================================

using System;
using static System.Net.Mime.MediaTypeNames;





public class Program
{


    static async Task Main(string[] args)
    {

        int each_guest = 0;
        int total_guest = 0;
        int order_guest = 0;
        int water_counter = 0;
        int coffee_counter = 0;
        int individual_guest = 0;
        int coffee = 1;
        int water = 2;

        {
            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99!  We only charge extra for coffee.");
            Console.WriteLine("How many people are in your group?  Please parties of 6 or lower.");
            total_guest = int.Parse(Console.ReadLine());
            if (total_guest >= 7)
            {
                Console.WriteLine("Oh sorry, can only seat parties up to 6.  Have a nice day.");

            }


            Console.Write("A table for  " + total_guest);
            Console.WriteLine();
            Console.Write("Please follow me and take a seat. Let's get everone started with some drinks.  ");
            do
            {
                order_guest = order_guest + 1;
                Console.WriteLine("Alright guest "); Console.WriteLine(order_guest + (".  Would you like coffee or a water?"));
                Console.WriteLine();
                string drink = Console.ReadLine();
                Console.WriteLine();
                Console.Write(drink + ", good choice!");
                Console.WriteLine();
                Console.WriteLine();
                if (drink == "coffee")
                    coffee_counter = coffee_counter + 1;

                else if (drink == "water")
                    water_counter = water_counter + 1;

                else
                {
                    bool v2 = drink is not "water" or not "coffee";
                    bool v1 = v2;
                    Console.Write(drink + ("We don't have that.  No drink for you!"));
                }

            } while (order_guest < total_guest);
            {
                Console.WriteLine("Okay, so that's "); Console.WriteLine(coffee_counter + (" coffee's and")); Console.WriteLine(water_counter + ("  water."));
                Console.WriteLine();
                Console.WriteLine("I'll be right back. Feel free to grab your food!");
                Console.WriteLine();
                double buffet_price = ((double)(total_guest * 9.99));
                int coffee_price = coffee_counter * 2;
                double total_price = buffet_price + coffee_price;
                Console.WriteLine("Here's your total bill!  The total price is: " + total_price);
            }

        }
    }
}


