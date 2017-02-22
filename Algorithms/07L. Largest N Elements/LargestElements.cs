namespace _07L.Largest_N_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LargestElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            var result = new List<int>(); 
            numbers.Sort();
            numbers.Reverse();
            //var result = numbers.Take(n);
            for (int i = 0; i < n; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
