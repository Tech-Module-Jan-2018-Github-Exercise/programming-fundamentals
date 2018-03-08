using System;

namespace GithubExercisePr2
{
    class Pr2RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width * height:F2}");
        }
    }
}
