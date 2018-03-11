//CONFIRMED from NikolaiStoilkov

using System;

namespace GithubExercisePr2
{
    class Pr2RectangleArea
    {
        static void Main(string[] args)
        {
	// Here we take the parameters for the rectangle area. 
            double width = double.Parse(Console.ReadLine()); 
            double height = double.Parse(Console.ReadLine());

	// Here we print the rectangle area by the formula 
	//Format is to the second decimal place.
            Console.WriteLine($"{width * height:F2}");
        }
    }
}
