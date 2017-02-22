namespace _03L.ReverseArray
{
    using System;
    using System.Linq;

    class ReverseArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
