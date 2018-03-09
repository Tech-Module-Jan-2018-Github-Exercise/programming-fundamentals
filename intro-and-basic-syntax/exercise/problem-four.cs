//CONFIRMED from NikolaiStoilkov
using System;

namespace CSharp_Intro_and_Basic_Syntax___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfProduct = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double result1 = (volume * energy) / 100.00;
            double result2 = (sugar * volume) / 100.00;

            Console.WriteLine($"{volume}ml {nameOfProduct}:");
            Console.WriteLine($"{result1}kcal, {result2}g sugars");
        }
    }
}