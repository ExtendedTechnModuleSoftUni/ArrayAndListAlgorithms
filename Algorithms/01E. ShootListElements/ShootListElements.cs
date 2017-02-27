namespace _01E.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShootListElements
    {
        static void Main()
        {
            var numbers = new List<int>();
            string input = Console.ReadLine();
            int lastRemolvedElement = 0;

            while (input != "stop")
            {
                if (input != "bang")
                {
                    AddingIntegers(numbers, input);
                }
                else
                {
                    if (numbers.Count > 0)
                    {
                        lastRemolvedElement = RemovingElements(numbers, lastRemolvedElement);
                        DecreasingAllElementsByOne(numbers);
                    }
                    else
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemolvedElement}");
                        return;
                    }
                }

                input = Console.ReadLine();
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastRemolvedElement}");
            }
        }

        private static void DecreasingAllElementsByOne(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        private static int RemovingElements(List<int> numbers, int lastRemovedElement)
        {
            double avarage = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= avarage)
                {
                    lastRemovedElement = numbers[i];
                    Console.WriteLine($"shot {lastRemovedElement}");
                    numbers.RemoveAt(i);
                    break;
                }
            }

            return lastRemovedElement;
        }

        private static void AddingIntegers(List<int> numbers, string input)
        {
            numbers.Insert(0, int.Parse(input));
        }
    }
}
