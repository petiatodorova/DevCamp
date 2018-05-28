using System;

namespace SurvivalMessage
{
    class Message
    {
        static void Main(string[] args)
        {
            byte nNum = byte.Parse(Console.ReadLine());
            char firstUpper = char.Parse(Console.ReadLine());
            char lowerLetter = char.Parse(Console.ReadLine());
            char secondUpper = char.Parse(Console.ReadLine());
            byte mNum = byte.Parse(Console.ReadLine());
            byte count = byte.Parse(Console.ReadLine());

            byte sum = 0;

            for (byte firstPos = nNum; firstPos <= 99; firstPos++)
            {
                for (char secondPos = firstUpper; secondPos <= 'Z'; secondPos++)
                {
                    for (char thirdPos = lowerLetter; thirdPos <= 'z'; thirdPos++)
                    {
                        for (char fourthPos = secondUpper; fourthPos <= 'Z'; fourthPos++)
                        {
                            for (byte fifthPos = mNum; fifthPos >= 10; fifthPos--)
                            {
                                if ((fifthPos % 10 == 5) && (firstPos % 10 == 2))
                                {
                                    sum++;
                                    if (sum == count)
                                    {
                                        Console.WriteLine($"{firstPos}{secondPos}{thirdPos}{fourthPos}{fifthPos}");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
