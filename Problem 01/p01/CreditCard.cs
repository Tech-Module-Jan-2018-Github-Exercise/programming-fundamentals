using System;
using System.Collections.Generic;
using System.Linq;

namespace p02
{
    class CreditCard
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;


            for (int i = 0; i < 4; i++)
            {

                int number = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    num1 += number;
                }
                else if (i == 1)
                {
                    num2 += number;
                }
                else if (i == 2)
                {
                    num3 += number;
                }
                else if (i == 3)
                {
                    num4 += number;
                }

            }

            Console.WriteLine($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}
