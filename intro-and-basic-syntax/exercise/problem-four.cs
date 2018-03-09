//CONFIRMED from NikolaiStoilkov
using System;

namespace CSharp_Intro_and_Basic_Syntax___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //We receive from the console the product name as-> a string;
            string nameOfProduct = Console.ReadLine();              
            
            /*In the  next three lins, we receive volume, energy and 
             *sugar content of our product as an integer*/
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());


          // We calculate in the next lines:...
            double result1 = (volume * energy) / 100.00;
            double result2 = (sugar * volume) / 100.00;

            // We print the end result as follows:
            Console.WriteLine($"{volume}ml {nameOfProduct}:");
            Console.WriteLine($"{result1}kcal, {result2}g sugars");
        }
    }
}