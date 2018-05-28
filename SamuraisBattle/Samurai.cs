using System;
using System.Collections.Generic;
using System.Linq;

namespace SamuraisBattle
{
    class Samurai
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            int count = numbers.Count();
            int countSamurais = count;
            int attackerIndex;
            int targetIndex;

            if (count > 0)
            {
                while (true)
                {
                    if (count == 1)
                    {
                        return;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        attackerIndex = i;
                        if (numbers[attackerIndex] != -1)
                        {
                            targetIndex = numbers[attackerIndex];
                            if (targetIndex > count)
                            {
                                targetIndex = targetIndex % count;
                            }

                            int difference = Math.Abs(attackerIndex - targetIndex);

                            if (difference == 0)
                            {
                                Console.WriteLine($"{attackerIndex} performed harakiri");
                                numbers[attackerIndex] = -1;
                                countSamurais--;
                                if (countSamurais == 1)
                                {
                                    return;
                                }
                            }
                            else if (difference % 2 == 0)
                            {
                                Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                                numbers[targetIndex] = -1;
                                countSamurais--;
                                if (countSamurais == 1)
                                {
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                                numbers[attackerIndex] = -1;
                                countSamurais--;
                                if (countSamurais == 1)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    List<int> numbersHelper = numbers.Where(x => x != -1).ToList();
                    numbers = numbersHelper;
                    count = numbers.Count();
                }
            }
        }
    }
}
