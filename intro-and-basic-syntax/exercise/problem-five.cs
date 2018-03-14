//CONFIRMED by bobykostov
using System;

namespace CharacterHealth
{
    class Program
    {
        static void Main(string[] args)
        {
			/*In the following lines we acquire the character's
			name, current health and energy, and maximum health
			and energy*/
            string name = Console.ReadLine();
            int Health = int.Parse(Console.ReadLine());
            int HealthMax = int.Parse(Console.ReadLine());
            int Energy = int.Parse(Console.ReadLine());
            int EnergyMax = int.Parse(Console.ReadLine());
			
			/*We print out their name*/
            Console.WriteLine("Name: {0}", name);
			
			/*We print their health points in the form of a
			video game health bar where the available health
			is presented with vertical bars and the health lost - 
			with dots*/
            Console.Write("Health: ");
            Console.Write("|");
            Console.Write (new string('|', Health));
            Console.Write (new string('.', HealthMax - Health));
            Console.WriteLine("|");
			
			/*Same operation as above with respect to energy.*/
            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write (new string('|', Energy));
            Console.Write (new string('.', EnergyMax - Energy));
            Console.WriteLine("|");
        }
    }
}
