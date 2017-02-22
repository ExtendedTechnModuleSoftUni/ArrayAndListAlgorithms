namespace _06L.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class InsertionSortUsingList
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    int current = numbers[j - 1];
                    int next = numbers[j];

                    if (next < current)
                    {
                        numbers.Insert(j - 1, next);
                        numbers.RemoveAt(j + 1);
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
