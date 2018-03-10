//Documented by bobykostov
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
			/*We initialize a constant from the data type 'double'
			and assign it the length of a mile in kilometers as value.*/
            const double mile = 1.60934;
			
			/*We read the value we want to convert into kilometers
			from the console, convert it into double from string
			and assign it to a variable*/
            double miles = double.Parse(Console.ReadLine());
			
			/*We convert by multiplying the number of miles by
			the length of a single mile in kilometers and assign
			the product as a value to another variable.*/
            double kilometers = miles * mile;

			/*Finally, we print out the previously defined value,
			the conversion from miles to kilometers, formated to
			the second digit past the floating point*/
            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}