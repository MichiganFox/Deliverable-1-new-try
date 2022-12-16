//===========================================================
//
// Title:         Deliverable 1 C# 
//  Author :      Earle Fox>
//  Date :        11/28/2022
//  Description : Feed the Neighborhood -calculate the amount of supplies needed to make peanut butter and jelly sandwhiches
//       
//===========================================================

using System;
using static System.Net.Mime.MediaTypeNames;





public class Program
{
    static async Task Main(string[] args)
    {


        int restart_answer = 1;

        do
        {


            Console.WriteLine("How many people are we making PB and J sandwhiches for?     ");
            double sandwhich_number = int.Parse(Console.ReadLine());
            double slicedbread_number = sandwhich_number * 2;
            Console.WriteLine();
            Console.WriteLine("You need:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(slicedbread_number); Console.WriteLine("  slices of bread");
            double peanutbutter_number = sandwhich_number * 2;
            Console.WriteLine(peanutbutter_number); Console.WriteLine("  tablespoons of peanut butter");
            double jelly_number = sandwhich_number * 4;
            Console.WriteLine(jelly_number); Console.WriteLine("  teaspoons of jelly");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("which is...");
            Console.WriteLine();
            Console.WriteLine();
            double totalloafs_number = Math.Ceiling(slicedbread_number / 28);
            Console.WriteLine(totalloafs_number); Console.WriteLine("  loaves of bread");
            double totalpeanutbutterjars_number = Math.Ceiling(slicedbread_number / 32);
            Console.WriteLine(totalpeanutbutterjars_number); Console.WriteLine("  jars of peanut butter");
            double totaljellyjars_number = Math.Ceiling(slicedbread_number / 48);
            Console.WriteLine(totaljellyjars_number); Console.WriteLine("  jars of jelly");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Would you like to restart?  Enter yes or y to continue, or enter any other 2 keys to exit.");
        } while ((Console.ReadLine() == "y") || (Console.ReadLine() == "yes"));
        Console.WriteLine("Good Bye!");
    }
}

