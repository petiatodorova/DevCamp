using System;
using System.Linq;

namespace DragonsHatching
{
    class Dragons
    {
        static void Main(string[] args)
        {
            sbyte amountOfTeams = sbyte.Parse(Console.ReadLine());
            double dragonHatchingValue = double.Parse(Console.ReadLine());
            double allSumPoints = 0.0;

            for (int i = 0; i < amountOfTeams; i++)
            {
                int[] line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // BigInteger?
                int dragonsHatched = line[0];
                int teamMembersCount = line[1];

                double teamPoints = 1.0 * dragonsHatched / teamMembersCount;
                allSumPoints += teamPoints;
            }

            if (dragonHatchingValue == 0)
            {
                Console.WriteLine($"{allSumPoints:F3}");
            }
            else
            {
                double points = allSumPoints / dragonHatchingValue;
                Console.WriteLine($"{(points):F3}");
            }
        }
    }
}
