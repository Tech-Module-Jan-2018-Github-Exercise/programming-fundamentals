using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mile =1.60934;
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * mile;

            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}