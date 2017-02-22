namespace _05L.InsertionSort
{
    using System;
    using System.Linq;

    class InsertionSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    int current = numbers[j - 1];
                    int next = numbers[j];

                    if (next < current)
                    {
                        numbers[j] = current;
                        numbers[j - 1] = next;
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
