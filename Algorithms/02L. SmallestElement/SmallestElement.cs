namespace _02L.SmallestElement
{
    using System;
    using System.Linq;

    class SmallestElement
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
