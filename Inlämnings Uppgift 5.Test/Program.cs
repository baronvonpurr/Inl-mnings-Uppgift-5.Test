using System;

namespace Uppgift5_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            int[] ålder = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Skriv in namnet på en klasskamrat: ");
                namn[i] = Console.ReadLine();
                Console.Write("Skriv in åldern på klasskamraten: ");
                ålder[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Medelåldern på klasskamraterna är {(ålder[0] + ålder[1] + ålder[2] + ålder[3] + ålder[4]) / 5}");
        }
    }
}