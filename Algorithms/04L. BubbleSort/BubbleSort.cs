namespace _04L.BubbleSort
{
    using System;
    using System.Linq;

    class BubbleSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool swap = false;

            do
            {
                swap = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        swap = true;
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }

            } while (swap);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
